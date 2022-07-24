using System.Collections.Generic;

namespace TestActivePermissionConfig
{
    public class AdministrationActiveFlagConfiguration
    {
        public static Dictionary<string, List<PermissionActiveFlagsConfig>> Configs = new Dictionary<string, List<PermissionActiveFlagsConfig>>()
        {
            {
                "PermissionRequirements.Administration.Client", new List<PermissionActiveFlagsConfig>()
                {
                    new PermissionActiveFlagsConfig(
                        enabledFlags => enabledFlags.Contains("Accounting") &&
                                        enabledFlags.Contains("IsChannelPartner"),
                        "PermissionRequirements.Administration.Client",
                        "OperationAuthorizationRequirements.Read",
                        "OperationAuthorizationRequirements.Create",
                        "OperationAuthorizationRequirements.Update",
                        "OperationAuthorizationRequirements.Delete"
                    )
                }
            }
        };
    }
}