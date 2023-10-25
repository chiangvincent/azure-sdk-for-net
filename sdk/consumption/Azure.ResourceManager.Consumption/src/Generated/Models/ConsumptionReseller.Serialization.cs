// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionReseller
    {
        internal static ConsumptionReseller DeserializeConsumptionReseller(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resellerId = default;
            Optional<string> resellerDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resellerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resellerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resellerDescription"u8))
                {
                    resellerDescription = property.Value.GetString();
                    continue;
                }
            }
            return new ConsumptionReseller(resellerId.Value, resellerDescription.Value);
        }
    }
}
