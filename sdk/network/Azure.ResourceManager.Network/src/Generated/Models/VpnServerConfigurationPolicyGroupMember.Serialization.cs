// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigurationPolicyGroupMember : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AttributeType))
            {
                writer.WritePropertyName("attributeType"u8);
                writer.WriteStringValue(AttributeType.Value.ToString());
            }
            if (Optional.IsDefined(AttributeValue))
            {
                writer.WritePropertyName("attributeValue"u8);
                writer.WriteStringValue(AttributeValue);
            }
            writer.WriteEndObject();
        }

        internal static VpnServerConfigurationPolicyGroupMember DeserializeVpnServerConfigurationPolicyGroupMember(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<VpnPolicyMemberAttributeType> attributeType = default;
            Optional<string> attributeValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributeType = new VpnPolicyMemberAttributeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attributeValue"u8))
                {
                    attributeValue = property.Value.GetString();
                    continue;
                }
            }
            return new VpnServerConfigurationPolicyGroupMember(name.Value, Optional.ToNullable(attributeType), attributeValue.Value);
        }
    }
}
