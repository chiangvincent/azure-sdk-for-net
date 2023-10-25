// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultContentKeyPolicyName))
            {
                writer.WritePropertyName("defaultContentKeyPolicyName"u8);
                writer.WriteStringValue(DefaultContentKeyPolicyName);
            }
            if (Optional.IsDefined(EnvelopeEncryption))
            {
                writer.WritePropertyName("envelopeEncryption"u8);
                writer.WriteObjectValue(EnvelopeEncryption);
            }
            if (Optional.IsDefined(CommonEncryptionCenc))
            {
                writer.WritePropertyName("commonEncryptionCenc"u8);
                writer.WriteObjectValue(CommonEncryptionCenc);
            }
            if (Optional.IsDefined(CommonEncryptionCbcs))
            {
                writer.WritePropertyName("commonEncryptionCbcs"u8);
                writer.WriteObjectValue(CommonEncryptionCbcs);
            }
            if (Optional.IsDefined(NoEncryption))
            {
                writer.WritePropertyName("noEncryption"u8);
                writer.WriteObjectValue(NoEncryption);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StreamingPolicyData DeserializeStreamingPolicyData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> created = default;
            Optional<string> defaultContentKeyPolicyName = default;
            Optional<EnvelopeEncryption> envelopeEncryption = default;
            Optional<CommonEncryptionCenc> commonEncryptionCenc = default;
            Optional<CommonEncryptionCbcs> commonEncryptionCbcs = default;
            Optional<NoEncryption> noEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("defaultContentKeyPolicyName"u8))
                        {
                            defaultContentKeyPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("envelopeEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            envelopeEncryption = EnvelopeEncryption.DeserializeEnvelopeEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("commonEncryptionCenc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commonEncryptionCenc = CommonEncryptionCenc.DeserializeCommonEncryptionCenc(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("commonEncryptionCbcs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commonEncryptionCbcs = CommonEncryptionCbcs.DeserializeCommonEncryptionCbcs(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("noEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            noEncryption = NoEncryption.DeserializeNoEncryption(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StreamingPolicyData(id, name, type, systemData.Value, Optional.ToNullable(created), defaultContentKeyPolicyName.Value, envelopeEncryption.Value, commonEncryptionCenc.Value, commonEncryptionCbcs.Value, noEncryption.Value);
        }
    }
}
