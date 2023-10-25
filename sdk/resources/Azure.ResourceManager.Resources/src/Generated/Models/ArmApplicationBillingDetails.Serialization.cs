// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ArmApplicationBillingDetails
    {
        internal static ArmApplicationBillingDetails DeserializeArmApplicationBillingDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceUsageId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUsageId"u8))
                {
                    resourceUsageId = property.Value.GetString();
                    continue;
                }
            }
            return new ArmApplicationBillingDetails(resourceUsageId.Value);
        }
    }
}
