// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBIncludedPath : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Indexes))
            {
                writer.WritePropertyName("indexes"u8);
                writer.WriteStartArray();
                foreach (var item in Indexes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBIncludedPath DeserializeCosmosDBIncludedPath(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<IList<CosmosDBPathIndexes>> indexes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBPathIndexes> array = new List<CosmosDBPathIndexes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBPathIndexes.DeserializeCosmosDBPathIndexes(item));
                    }
                    indexes = array;
                    continue;
                }
            }
            return new CosmosDBIncludedPath(path.Value, Optional.ToList(indexes));
        }
    }
}
