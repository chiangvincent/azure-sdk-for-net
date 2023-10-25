// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AmlToken : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identityType"u8);
            writer.WriteStringValue(IdentityType.ToString());
            writer.WriteEndObject();
        }

        internal static AmlToken DeserializeAmlToken(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IdentityConfigurationType identityType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identityType"u8))
                {
                    identityType = new IdentityConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new AmlToken(identityType);
        }
    }
}
