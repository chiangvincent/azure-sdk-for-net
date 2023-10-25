// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyOption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("configuration"u8);
            writer.WriteObjectValue(Configuration);
            writer.WritePropertyName("restriction"u8);
            writer.WriteObjectValue(Restriction);
            writer.WriteEndObject();
        }

        internal static ContentKeyPolicyOption DeserializeContentKeyPolicyOption(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> policyOptionId = default;
            Optional<string> name = default;
            ContentKeyPolicyConfiguration configuration = default;
            ContentKeyPolicyRestriction restriction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyOptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyOptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    configuration = ContentKeyPolicyConfiguration.DeserializeContentKeyPolicyConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("restriction"u8))
                {
                    restriction = ContentKeyPolicyRestriction.DeserializeContentKeyPolicyRestriction(property.Value);
                    continue;
                }
            }
            return new ContentKeyPolicyOption(Optional.ToNullable(policyOptionId), name.Value, configuration, restriction);
        }
    }
}
