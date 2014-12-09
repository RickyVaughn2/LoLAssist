﻿namespace LoLAssist.MatchEndpoint
{
    /// <summary>
    /// Type of level up (Match API).
    /// </summary>
    public enum LevelUpType
    {
        /// <summary>
        /// When leveling up involves evolving (notably Kha'zix).
        /// </summary>
        Evolve,

        /// <summary>
        /// Normal leveling up.
        /// </summary>
        Normal
    }

    internal static class LevelUpTypeExtension
    {
        public static string ToCustomString(this LevelUpType levelUpType)
        {
            switch (levelUpType)
            {
                case LevelUpType.Evolve:
                    return "EVOLVE";

                case LevelUpType.Normal:
                    return "NORMAL";

                default:
                    return string.Empty;
            }
        }
    }
}