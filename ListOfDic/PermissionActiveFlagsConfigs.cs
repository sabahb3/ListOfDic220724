using System.Collections.Generic;

namespace TestActivePermissionConfig
{
    public class PermissionActiveFlagsConfigs
    {
        public static List<Dictionary<string,List<PermissionActiveFlagsConfig>>> Configs { get; }= SetConfigs();

        private static List<Dictionary<string,List<PermissionActiveFlagsConfig>>> SetConfigs()
        {
            var confgs = new List<Dictionary<string,List<PermissionActiveFlagsConfig>>>();
            confgs.Add(AccountsPayableActiveFlagsConfiguration.Configs);
            confgs.Add(AdministrationActiveFlagConfiguration.Configs);
            return confgs;
        }
    }
}