using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using LetsRaid.Models;
using Newtonsoft.Json;
using RestSharp;

namespace LetsRaid.Clients
{
    public class CharacterClient
    {
        private readonly IRestClient _restClient;

        public CharacterClient()
        {
            _restClient = new RestClient(ConfigurationManager.AppSettings["BaseBlizzerdUrl"]);
        }
        public async Task<IEnumerable<Character>> GetCharacter(string charName, int itmLvl)
        {
            var request = new RestRequest("", Method.GET);
            request.Parameters.Add(new Parameter()
            {
                Name = "charName",
                Type = ParameterType.QueryString,
                Value = charName
            });
            request.Parameters.Add(new Parameter()
            {
                Name = "itmLvl",
                Type = ParameterType.QueryString,
                Value = itmLvl
            });

            var response = await _restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<IEnumerable<Character>>(response.Content);
        }
    }
}