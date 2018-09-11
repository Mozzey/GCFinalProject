using LetsRaid.Models;
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
            //request.Parameters.Add(new Parameter()
            //{
            //    Name = "name",
            //    Type = ParameterType.QueryString,
            //    Value = charName
            //});
            //request.Parameters.Add(new Parameter()
            //{
            //    Name = "averageItemLevel",
            //    Type = ParameterType.QueryString,
            //    Value = itmLvl
            //});
            var items = _restClient.ExecuteTaskAsync(itemRequest);
            var itemResponse = await items;
            return JsonConvert.DeserializeObject<Character>(itemResponse.Content);
        }

        public async Task<Character> GetMembers()
        {
            var membersUrl = "guild/Dalaran/Ruinous?fields=members&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            var memberRequest = new RestRequest(membersUrl, Method.GET);


            var members = _restClient.ExecuteTaskAsync(memberRequest);
            var memberResponse = await members;
            return JsonConvert.DeserializeObject<Character>(memberResponse.Content);
        }

    }
}