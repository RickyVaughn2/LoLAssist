using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoLAssist.SummonerEndpoint
{
    internal class RunePages
    {
        /// <summary>
        /// List of RunePages;
        /// </summary>
        [JsonProperty("pages")]
        public List<RunePage> Pages { get; set; }

        /// <summary>
        /// Summoner ID to wich the pages belong.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}