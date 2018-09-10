using BattleDotNet;
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
        private readonly DynamicClient _wowClient = new DynamicClient("wow");

        public CharacterClient()
        {
            _restClient = new RestClient(ConfigurationManager.AppSettings["BaseBlizzerdUrl"]);
        }
        public async Task<Character> GetCharacter()
        {
            var itemUrl = "Sargeras/Boodrilmer?fields=items&locale=en_US&apikey=yku5p7jc26x5pnnj9qy73ufdfh48pgqj";
            
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

        //public async Task<Auction> GetAuction()
        //{
        //    var ahUrl = "http://auction-api-us.worldofwarcraft.com/auction-data/81649e5a17eae71db97e26ffce7bdabe/auctions.json";
        //    var ahRequest = new RestRequest(ahUrl, Method.GET);

        //    var ah = _restClient.ExecuteTaskAsync(ahRequest);
        //    var ahResponse = await ah;

        //    return JsonConvert.DeserializeObject<Auction>(ahResponse.Content);

        //}

    }
}