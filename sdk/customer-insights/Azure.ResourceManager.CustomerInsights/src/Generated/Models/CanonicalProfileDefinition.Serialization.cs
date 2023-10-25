// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class CanonicalProfileDefinition
    {
        internal static CanonicalProfileDefinition DeserializeCanonicalProfileDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> canonicalProfileId = default;
            Optional<IReadOnlyList<CanonicalProfileDefinitionPropertiesItem>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canonicalProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canonicalProfileId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CanonicalProfileDefinitionPropertiesItem> array = new List<CanonicalProfileDefinitionPropertiesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CanonicalProfileDefinitionPropertiesItem.DeserializeCanonicalProfileDefinitionPropertiesItem(item));
                    }
                    properties = array;
                    continue;
                }
            }
            return new CanonicalProfileDefinition(Optional.ToNullable(canonicalProfileId), Optional.ToList(properties));
        }
    }
}
