// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBAccountCapacity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TotalThroughputLimit))
            {
                writer.WritePropertyName("totalThroughputLimit"u8);
                writer.WriteNumberValue(TotalThroughputLimit.Value);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBAccountCapacity DeserializeCosmosDBAccountCapacity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> totalThroughputLimit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalThroughputLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalThroughputLimit = property.Value.GetInt32();
                    continue;
                }
            }
            return new CosmosDBAccountCapacity(Optional.ToNullable(totalThroughputLimit));
        }
    }
}
