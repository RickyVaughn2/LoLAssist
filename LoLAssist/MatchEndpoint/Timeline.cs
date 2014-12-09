using LoLAssist;
using LoLAssist.MatchEndpoint;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LoLassist.MatchEndpoint
{
    /// <summary>
    /// Class representing a match's timeline (Match API).
    /// </summary>
    [Serializable]
    public class Timeline
    {
        internal Timeline()
        {
        }

        /// <summary>
        /// Time between each returned frame.
        /// </summary>
        [JsonProperty("frameInterval")]
        [JsonConverter(typeof(TimeSpanConverterFromMS))]
        public TimeSpan FrameInterval { get; set; }

        /// <summary>
        /// List of timeline frames for the game.
        /// </summary>
        [JsonProperty("frames")]
        public List<Frame> Frames { get; set; }
    }
}