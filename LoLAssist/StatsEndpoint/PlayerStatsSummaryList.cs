using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoLAssist.StatsEndpoint
{
    internal class PlayerStatsSummaryList
    {
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatsSummary> PlayerStatSummaries { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}