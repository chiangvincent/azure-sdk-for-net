// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBLocationListResult
    {
        internal static CosmosDBLocationListResult DeserializeCosmosDBLocationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CosmosDBLocationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBLocationData> array = new List<CosmosDBLocationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBLocationData.DeserializeCosmosDBLocationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBLocationListResult(Optional.ToList(value));
        }
    }
}
