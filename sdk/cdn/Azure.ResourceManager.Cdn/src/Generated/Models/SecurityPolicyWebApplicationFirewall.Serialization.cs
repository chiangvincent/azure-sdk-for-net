// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class SecurityPolicyWebApplicationFirewall : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WafPolicy))
            {
                writer.WritePropertyName("wafPolicy"u8);
                JsonSerializer.Serialize(writer, WafPolicy);
            }
            if (Optional.IsCollectionDefined(Associations))
            {
                writer.WritePropertyName("associations"u8);
                writer.WriteStartArray();
                foreach (var item in Associations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static SecurityPolicyWebApplicationFirewall DeserializeSecurityPolicyWebApplicationFirewall(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> wafPolicy = default;
            Optional<IList<SecurityPolicyWebApplicationFirewallAssociation>> associations = default;
            SecurityPolicyType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wafPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wafPolicy = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("associations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityPolicyWebApplicationFirewallAssociation> array = new List<SecurityPolicyWebApplicationFirewallAssociation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityPolicyWebApplicationFirewallAssociation.DeserializeSecurityPolicyWebApplicationFirewallAssociation(item));
                    }
                    associations = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SecurityPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityPolicyWebApplicationFirewall(type, wafPolicy, Optional.ToList(associations));
        }
    }
}
