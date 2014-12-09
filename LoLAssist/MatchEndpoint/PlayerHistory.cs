using LoLAssist.MatchEndpoint;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoLassist.MatchEndpoint
{
    internal class PlayerHistory
    {
        /// <summary>
        /// List of matches for the player.
        /// </summary>
        [JsonProperty("matches")]
        public List<MatchSummary> Matches { get; set; }
    }
}