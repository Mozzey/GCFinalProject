using LetsRaid.Models;
using LetsRaid.Models.GuildModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LetsRaid.Clients
{
    public class BossClient
    {
        private readonly IRestClient _restClient;

        public BossClient()
        {
            _restClient = new RestClient(ConfigurationManager.AppSettings["BaseBlizzardUrl"]);
        }

        public async Task<BossTable> GetBosses()
        {
            var bossUrl = "boss/?locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            var bossRequest = new RestRequest(bossUrl, Method.GET);

            var bosses = _restClient.ExecuteTaskAsync(bossRequest);
            var bossResponse = await bosses;
            return JsonConvert.DeserializeObject<BossTable>(bossResponse.Content);
        }
    }
}