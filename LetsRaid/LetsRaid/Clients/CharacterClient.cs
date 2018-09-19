using LetsRaid.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Threading.Tasks;

namespace LetsRaid.Clients
{
    public class CharacterClient
    {
        private readonly IRestClient _restClient;

        public CharacterClient()
        {
            _restClient = new RestClient(ConfigurationManager.AppSettings["BaseBlizzardUrl"]);
        }
        public async Task<Character> GetCharacter()
        {
            var itemUrl = "character/Sargeras/Boodrilmer?fields=items&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            
            var itemRequest = new RestRequest(itemUrl, Method.GET);

            var items = _restClient.ExecuteTaskAsync(itemRequest);
            var itemResponse = await items;
            return JsonConvert.DeserializeObject<Character>(itemResponse.Content);
        }

        public async Task<Guild> GetMembers(string serverName, string guildName)
        {
            var membersUrl = string.Format("guild/{0}/{1}?fields=members&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj", serverName, guildName);
            //var membersUrl = "guild/Dalaran/Ruinous?fields=members&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            var memberRequest = new RestRequest(membersUrl, Method.GET);


            var members = _restClient.ExecuteTaskAsync(memberRequest);
            var memberResponse = await members;
            return JsonConvert.DeserializeObject<Guild>(memberResponse.Content);
        }

        public async Task<Character> Details(string serverName, string characterName)
        {
            var characterUrl = string.Format("character/{0}/{1}?fields=items&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj", serverName, characterName);
            var characterRequest = new RestRequest(characterUrl, Method.GET);
            var character = _restClient.ExecuteTaskAsync(characterRequest);
            var characterResponse = await character;
            return JsonConvert.DeserializeObject<Character>(characterResponse.Content);
        }

    }
}