// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Models
{
    internal partial class BlueprintList
    {
        internal static BlueprintList DeserializeBlueprintList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<BlueprintData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BlueprintData> array = new List<BlueprintData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BlueprintData.DeserializeBlueprintData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BlueprintList(Optional.ToList(value), nextLink.Value);
        }
    }
}
