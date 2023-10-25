// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SemanticConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("prioritizedFields"u8);
            writer.WriteObjectValue(PrioritizedFields);
            writer.WriteEndObject();
        }

        internal static SemanticConfiguration DeserializeSemanticConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            PrioritizedFields prioritizedFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prioritizedFields"u8))
                {
                    prioritizedFields = PrioritizedFields.DeserializePrioritizedFields(property.Value);
                    continue;
                }
            }
            return new SemanticConfiguration(name, prioritizedFields);
        }
    }
}
