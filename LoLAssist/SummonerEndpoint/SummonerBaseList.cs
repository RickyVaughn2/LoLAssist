using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoLAssist.SummonerEndpoint
{
    internal class SummonerBaseList
    {
        [JsonProperty("summoners")]
        public List<SummonerBase> Summoners { get; set; }
    }
}