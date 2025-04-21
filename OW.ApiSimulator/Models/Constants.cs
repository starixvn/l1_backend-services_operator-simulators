using System.Collections.Generic;

namespace OW.ApiSimulator.Models
{
    public static class Constants
    {
        public static readonly string[] Operators = { "ow", "sbo", "ow_vg", "pff", "ONEworksSeal888", "sabaplay", "sk", "ONEworksCredit", "ONEworksCash" };
        public static readonly Dictionary<string, string> ForcedToUseOWOperatorsMapper = new Dictionary<string, string> { { "ow_vg", "ow" }, { "ONEworksSeal888", "ow" }, { "ONEworksCredit", "ow" }, { "ONEworksCash", "ow" } };

        public static readonly Dictionary<string, string> OperatorIds = new Dictionary<string,string>
        {
            {"ow", "ONEworks1" },
            {"sbo", "ONEworksVGCash" }
        };

        public static readonly Dictionary<string, string> LoginLanguageMapper = new Dictionary<string, string>
        {
            {"en", "en-US" },
            {"vn", "vi-VN" },
            {"ch", "zh-TW" },
            {"cs", "zh-CN" },
            {"th", "th-TH" },
            {"id", "id-ID" },
        };

        public static string GetDefaultCurrency(string systemType)
        {
            return systemType switch
            {
                "SC1" => "$US",
                "VG2" => "INH",
                "GN" => "$US",
                _ => "$US"
            };
        }

        public static decimal GetDefaultMinBet(string systemType)
        {
            return systemType switch
            {
                "SC1" => 1,
                "VG2" => 10,
                "GN" => 1,
                _ => 1
            };
        }

        public static decimal GetDefaultMaxBet(string systemType)
        {
            return systemType switch
            {
                "SC1" => 3000,
                "VG2" => 20000,
                "GN" => 20000,
                _ => 20000
            };
        }
    }    
}