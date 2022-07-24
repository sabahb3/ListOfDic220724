using System;
using System.Collections.Generic;
using System.Linq;

namespace TestActivePermissionConfig
{
    public class PermissionActiveFlagsConfig
    {
        public string PermissionRequirement { get; }

        public List<string> OperationRequirements { get; }

        public Func<HashSet<string>, bool> IsActive { get; }

        public PermissionActiveFlagsConfig(Func<HashSet<string>, bool> isActiveFunc, string permissionRequirement, params string[] operationRequirements)
        {
            PermissionRequirement = permissionRequirement;
            OperationRequirements = operationRequirements.ToList();
            IsActive = isActiveFunc;
        }
    }
}