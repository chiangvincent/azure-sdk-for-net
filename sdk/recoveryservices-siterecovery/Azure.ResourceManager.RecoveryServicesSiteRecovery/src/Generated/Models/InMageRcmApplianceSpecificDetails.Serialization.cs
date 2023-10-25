// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmApplianceSpecificDetails
    {
        internal static InMageRcmApplianceSpecificDetails DeserializeInMageRcmApplianceSpecificDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<InMageRcmApplianceDetails>> appliances = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appliances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmApplianceDetails> array = new List<InMageRcmApplianceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmApplianceDetails.DeserializeInMageRcmApplianceDetails(item));
                    }
                    appliances = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new InMageRcmApplianceSpecificDetails(instanceType, Optional.ToList(appliances));
        }
    }
}
