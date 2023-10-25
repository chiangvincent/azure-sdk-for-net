// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class DdosSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProtectionMode))
            {
                writer.WritePropertyName("protectionMode"u8);
                writer.WriteStringValue(ProtectionMode.Value.ToString());
            }
            if (Optional.IsDefined(DdosProtectionPlan))
            {
                writer.WritePropertyName("ddosProtectionPlan"u8);
                JsonSerializer.Serialize(writer, DdosProtectionPlan);
            }
            writer.WriteEndObject();
        }

        internal static DdosSettings DeserializeDdosSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DdosSettingsProtectionMode> protectionMode = default;
            Optional<WritableSubResource> ddosProtectionPlan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionMode = new DdosSettingsProtectionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ddosProtectionPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ddosProtectionPlan = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new DdosSettings(Optional.ToNullable(protectionMode), ddosProtectionPlan);
        }
    }
}
