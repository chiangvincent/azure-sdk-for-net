// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class SupportQuotaChangeContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(Payload))
            {
                writer.WritePropertyName("payload"u8);
                writer.WriteStringValue(Payload);
            }
            writer.WriteEndObject();
        }

        internal static SupportQuotaChangeContent DeserializeSupportQuotaChangeContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> region = default;
            Optional<string> payload = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("payload"u8))
                {
                    payload = property.Value.GetString();
                    continue;
                }
            }
            return new SupportQuotaChangeContent(region.Value, payload.Value);
        }
    }
}
