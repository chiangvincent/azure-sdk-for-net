// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    internal partial class UnknownServicePlacementPolicyDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownServicePlacementPolicyDescription DeserializeUnknownServicePlacementPolicyDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServicePlacementPolicyType type = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownServicePlacementPolicyDescription(type);
        }
    }
}
