// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceCorsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Methods))
            {
                writer.WritePropertyName("methods"u8);
                writer.WriteStartArray();
                foreach (var item in Methods)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxAge))
            {
                writer.WritePropertyName("maxAge"u8);
                writer.WriteNumberValue(MaxAge.Value);
            }
            if (Optional.IsDefined(AllowCredentials))
            {
                writer.WritePropertyName("allowCredentials"u8);
                writer.WriteBooleanValue(AllowCredentials.Value);
            }
            writer.WriteEndObject();
        }

        internal static HealthcareApisServiceCorsConfiguration DeserializeHealthcareApisServiceCorsConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> origins = default;
            Optional<IList<string>> headers = default;
            Optional<IList<string>> methods = default;
            Optional<int> maxAge = default;
            Optional<bool> allowCredentials = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    origins = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("methods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    methods = array;
                    continue;
                }
                if (property.NameEquals("maxAge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCredentials = property.Value.GetBoolean();
                    continue;
                }
            }
            return new HealthcareApisServiceCorsConfiguration(Optional.ToList(origins), Optional.ToList(headers), Optional.ToList(methods), Optional.ToNullable(maxAge), Optional.ToNullable(allowCredentials));
        }
    }
}
