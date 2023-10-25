// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class GeoFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("relativePath"u8);
            writer.WriteStringValue(RelativePath);
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToSerialString());
            writer.WritePropertyName("countryCodes"u8);
            writer.WriteStartArray();
            foreach (var item in CountryCodes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GeoFilter DeserializeGeoFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string relativePath = default;
            GeoFilterAction action = default;
            IList<string> countryCodes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString().ToGeoFilterAction();
                    continue;
                }
                if (property.NameEquals("countryCodes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    countryCodes = array;
                    continue;
                }
            }
            return new GeoFilter(relativePath, action, countryCodes);
        }
    }
}
