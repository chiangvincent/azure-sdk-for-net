// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    internal static partial class CloudHsmClusterSkuNameExtensions
    {
        public static string ToSerialString(this CloudHsmClusterSkuName value) => value switch
        {
            CloudHsmClusterSkuName.StandardB1 => "Standard_B1",
            CloudHsmClusterSkuName.StandardB10 => "Standard B10",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CloudHsmClusterSkuName value.")
        };

        public static CloudHsmClusterSkuName ToCloudHsmClusterSkuName(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard_B1")) return CloudHsmClusterSkuName.StandardB1;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard B10")) return CloudHsmClusterSkuName.StandardB10;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CloudHsmClusterSkuName value.");
        }
    }
}
