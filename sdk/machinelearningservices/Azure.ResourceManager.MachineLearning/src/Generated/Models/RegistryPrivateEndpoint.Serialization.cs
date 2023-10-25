// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RegistryPrivateEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetArmId))
            {
                if (SubnetArmId != null)
                {
                    writer.WritePropertyName("subnetArmId"u8);
                    writer.WriteStringValue(SubnetArmId);
                }
                else
                {
                    writer.WriteNull("subnetArmId");
                }
            }
            writer.WriteEndObject();
        }

        internal static RegistryPrivateEndpoint DeserializeRegistryPrivateEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> subnetArmId = default;
            Optional<ResourceIdentifier> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnetArmId = null;
                        continue;
                    }
                    subnetArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new RegistryPrivateEndpoint(id.Value, subnetArmId.Value);
        }
    }
}
