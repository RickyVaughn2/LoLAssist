﻿using Newtonsoft.Json;
using System;

namespace LoLAssist.SummonerEndpoint
{
    /// <summary>
    /// Class representing a Mastery in the API.
    /// </summary>
    [Serializable]
    public class Mastery
    {
        internal Mastery()
        {
        }

        /// <summary>
        /// Mastery id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Mastery rank (i.e. the number of points put into this mastery).
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}