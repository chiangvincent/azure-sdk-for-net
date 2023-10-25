// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class PolicyScopeContractExtensions
    {
        public static string ToSerialString(this PolicyScopeContract value) => value switch
        {
            PolicyScopeContract.Tenant => "Tenant",
            PolicyScopeContract.Product => "Product",
            PolicyScopeContract.Api => "Api",
            PolicyScopeContract.Operation => "Operation",
            PolicyScopeContract.All => "All",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PolicyScopeContract value.")
        };

        public static PolicyScopeContract ToPolicyScopeContract(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tenant")) return PolicyScopeContract.Tenant;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Product")) return PolicyScopeContract.Product;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Api")) return PolicyScopeContract.Api;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Operation")) return PolicyScopeContract.Operation;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "All")) return PolicyScopeContract.All;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PolicyScopeContract value.");
        }
    }
}
