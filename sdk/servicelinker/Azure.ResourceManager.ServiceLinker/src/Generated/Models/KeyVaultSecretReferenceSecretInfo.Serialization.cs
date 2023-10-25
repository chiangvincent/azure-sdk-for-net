// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class KeyVaultSecretReferenceSecretInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                if (Version != null)
                {
                    writer.WritePropertyName("version"u8);
                    writer.WriteStringValue(Version);
                }
                else
                {
                    writer.WriteNull("version");
                }
            }
            writer.WritePropertyName("secretType"u8);
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static KeyVaultSecretReferenceSecretInfo DeserializeKeyVaultSecretReferenceSecretInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> version = default;
            LinkerSecretType secretType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        version = null;
                        continue;
                    }
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretType"u8))
                {
                    secretType = new LinkerSecretType(property.Value.GetString());
                    continue;
                }
            }
            return new KeyVaultSecretReferenceSecretInfo(secretType, name.Value, version.Value);
        }
    }
}
