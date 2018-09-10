using LetsRaid.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;
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
            var url = "Sargeras/Boodrilmer?fields=items&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            var request = new RestRequest(url, Method.GET);
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
            request.AddJsonBody("items");
            
            var response = await _restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<Character>(response.Content);
        }

    }
}