// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationEncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource"u8);
                writer.WriteStringValue(KeySource.Value.ToSerialString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            writer.WriteEndObject();
        }

        internal static AutomationEncryptionProperties DeserializeAutomationEncryptionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationKeyVaultProperties> keyVaultProperties = default;
            Optional<EncryptionKeySourceType> keySource = default;
            Optional<EncryptionPropertiesIdentity> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = AutomationKeyVaultProperties.DeserializeAutomationKeyVaultProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("keySource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keySource = property.Value.GetString().ToEncryptionKeySourceType();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = EncryptionPropertiesIdentity.DeserializeEncryptionPropertiesIdentity(property.Value);
                    continue;
                }
            }
            return new AutomationEncryptionProperties(keyVaultProperties.Value, Optional.ToNullable(keySource), identity.Value);
        }
    }
}
