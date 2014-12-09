using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LoLAssist.StaticDataEndpoint
{
    /// <summary>
    /// Class representing a list of mastery trees (Static API).
    /// </summary>
    [Serializable]
    public class MasteryTreeListStatic
    {
        internal MasteryTreeListStatic()
        {
        }

        /// <summary>
        /// List of mastery tree items.
        /// </summary>
        [JsonProperty("masteryTreeItems")]
        public List<MasteryTreeItemStatic> MasteryTreeItems { get; set; }
    }
}