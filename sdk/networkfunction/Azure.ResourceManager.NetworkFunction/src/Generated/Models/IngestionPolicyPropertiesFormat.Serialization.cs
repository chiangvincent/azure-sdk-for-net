// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    public partial class IngestionPolicyPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IngestionType))
            {
                writer.WritePropertyName("ingestionType"u8);
                writer.WriteStringValue(IngestionType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IngestionSources))
            {
                writer.WritePropertyName("ingestionSources"u8);
                writer.WriteStartArray();
                foreach (var item in IngestionSources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IngestionPolicyPropertiesFormat DeserializeIngestionPolicyPropertiesFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IngestionType> ingestionType = default;
            Optional<IList<IngestionSourcesPropertiesFormat>> ingestionSources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionType = new IngestionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingestionSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IngestionSourcesPropertiesFormat> array = new List<IngestionSourcesPropertiesFormat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IngestionSourcesPropertiesFormat.DeserializeIngestionSourcesPropertiesFormat(item));
                    }
                    ingestionSources = array;
                    continue;
                }
            }
            return new IngestionPolicyPropertiesFormat(Optional.ToNullable(ingestionType), Optional.ToList(ingestionSources));
        }
    }
}
