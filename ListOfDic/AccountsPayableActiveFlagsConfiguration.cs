using System.Collections.Generic;

namespace TestActivePermissionConfig
{
    public class AccountsPayableActiveFlagsConfiguration
    {
          public static Dictionary<string, List<PermissionActiveFlagsConfig>> Configs = new Dictionary<string, List<PermissionActiveFlagsConfig>>()
          {
                      {
                          "PermissionRequirements.AP.APInvoice", new List<PermissionActiveFlagsConfig>
                          {
                              new PermissionActiveFlagsConfig(
                                  enabledFlags => enabledFlags.Contains("FeatureNames.Accounting"),
                                  "PermissionRequirements.AP.APInvoice",
                                  "OperationAuthorizationRequirements.Read"
                              )
                          }
                      },
                      {
                          "PermissionRequirements.AP.PaymentRun", new List<PermissionActiveFlagsConfig>
                          {
                              new PermissionActiveFlagsConfig(
                                  enabledFlags => enabledFlags.Contains("FeatureNames.PaymentRunApprovals") &&
                                                  enabledFlags.Contains("ClientSettingNames.PaymentRunStorageEnabled"),
                                  "PermissionRequirements.AP.PaymentRun",
                                  "OperationAuthorizationRequirements.Create",
                                  "OperationAuthorizationRequirements.Update"
                              )
                          }
                      },
                      {
                          "PermissionRequirements.AP.AccountsPayablePayment", new List<PermissionActiveFlagsConfig>
                          {
                              new PermissionActiveFlagsConfig(
                                  enabledFlags => enabledFlags.Contains("FeatureNames.Accounting"),
                                  "PermissionRequirements.AP.AccountsPayablePayment",
                                  "OperationAuthorizationRequirements.Create"
                              )
                          }
                      },
                      {
                          "PermissionRequirements.AP.APCreditMemo", new List<PermissionActiveFlagsConfig>
                          {
                              new PermissionActiveFlagsConfig(
                                  enabledFlags => enabledFlags.Contains("FeatureNames.Accounting"),
                                  "PermissionRequirements.AP.APCreditMemo",
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