using System.Collections.Generic;
using System.Linq;

namespace TestActivePermissionConfig
{
    public class VisiblePermissions
    {
        public bool IsPermissionVisibleAsync(HashSet<string> activeFlags,string permissionRequirement, string operationRequirement)
        {
            var permissionActiveFlagsConfigs = PermissionActiveFlagsConfigs.Configs
                .FirstOrDefault(p => p.ContainsKey(permissionRequirement))?.GetValueOrDefault(permissionRequirement);
            var permissionActiveFlagsConfig = permissionActiveFlagsConfigs?.FirstOrDefault(
                a => a.OperationRequirements.Contains(operationRequirement));
            
            // If no flags attached to the permission, then the permission is active regardless of the enabled flags
            return permissionActiveFlagsConfig?.IsActive(activeFlags) ?? true;
        }
    }
}