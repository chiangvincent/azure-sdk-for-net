// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AddonVrProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vrsCount"u8);
            writer.WriteNumberValue(VrsCount);
            writer.WritePropertyName("addonType"u8);
            writer.WriteStringValue(AddonType.ToString());
            writer.WriteEndObject();
        }

        internal static AddonVrProperties DeserializeAddonVrProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int vrsCount = default;
            AddonType addonType = default;
            Optional<AddonProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vrsCount"u8))
                {
                    vrsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("addonType"u8))
                {
                    addonType = new AddonType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AddonProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AddonVrProperties(addonType, Optional.ToNullable(provisioningState), vrsCount);
        }
    }
}
