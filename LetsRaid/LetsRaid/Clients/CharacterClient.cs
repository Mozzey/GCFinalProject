using LetsRaid.Models;
using LetsRaid.Models.GuildModels;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRaid.Clients
{
    public class CharacterClient
    {
        private readonly IRestClient _restClient;

        public CharacterClient()
        {
            _restClient = new RestClient(ConfigurationManager.AppSettings["BaseBlizzerdUrl"]);
        }
        public async Task<Character> GetCharacter()
        {
            var itemUrl = "character/Sargeras/Boodrilmer?fields=items&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            
            var itemRequest = new RestRequest(itemUrl, Method.GET);

            var items = _restClient.ExecuteTaskAsync(itemRequest);
            var itemResponse = await items;
            return JsonConvert.DeserializeObject<Character>(itemResponse.Content);
        }

        public async Task<Guild> GetMembers()
        {
            var membersUrl = "guild/Dalaran/Ruinous?fields=members&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            var memberRequest = new RestRequest(membersUrl, Method.GET);


            var members = _restClient.ExecuteTaskAsync(memberRequest);
            var memberResponse = await members;
            return JsonConvert.DeserializeObject<Guild>(memberResponse.Content);
        }

    }
}