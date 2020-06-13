﻿using System.Collections.Generic;

namespace Discord
{
    public enum DiscordLanguage
    {
        Danish,
        German,
        EnglishUK,
        EnglishUS,
        Spanish,
        French,
        Croatian,
        Italian,
        Lithuanian,
        Hungarian,
        Dutch,
        Norwegian,
        Polish,
        Portuguese,
        Romanian,
        Finnish,
        Swedish,
        Viatnamese,
        Turkish,
        Czech,
        Greek,
        Bulgarian,
        Russian,
        Ukranian,
        Thai,
        Chinese,
        Japanese,
        ChineseThai,
        Korean
    }

    public static class LanguageUtils
    {
        private static readonly Dictionary<DiscordLanguage, string> Languages = new Dictionary<DiscordLanguage, string>()
        {
            { DiscordLanguage.Danish, "da" },
            { DiscordLanguage.German, "de" },
            { DiscordLanguage.EnglishUK, "en-GB" },
            { DiscordLanguage.EnglishUS, "en-US" },
            { DiscordLanguage.Spanish, "es-ES" },
            { DiscordLanguage.French, "fr" },
            { DiscordLanguage.Croatian, "hr" },
            { DiscordLanguage.Italian, "it" },
            { DiscordLanguage.Hungarian, "hu" },
            { DiscordLanguage.Dutch, "nl" },
            { DiscordLanguage.Norwegian, "no" },
            { DiscordLanguage.Polish, "pl" },
            { DiscordLanguage.Portuguese, "pt-BR" },
            { DiscordLanguage.Romanian, "ro" },
            { DiscordLanguage.Finnish, "fi" },
            { DiscordLanguage.Swedish, "sv-SE" },
            { DiscordLanguage.Viatnamese, "vi" },
            { DiscordLanguage.Turkish, "tr" },
            { DiscordLanguage.Czech, "cs" },
            { DiscordLanguage.Greek, "el" },
            { DiscordLanguage.Bulgarian, "bl" },
            { DiscordLanguage.Russian, "ru" },
            { DiscordLanguage.Ukranian, "uk" },
            { DiscordLanguage.Thai, "th" },
            { DiscordLanguage.Chinese, "zh-CN" },
            { DiscordLanguage.Japanese, "ja" },
            { DiscordLanguage.Korean, "ko" }
        };

        public static string LanguageToString(DiscordLanguage lang)
        {
            return Languages[lang];
        }

        public static DiscordLanguage StringToLanguage(string langStr)
        {
            foreach (var language in Languages)
            {
                if (language.Value == langStr)
                    return language.Key;
            }

            return DiscordLanguage.EnglishUS;
        }
    }
}
