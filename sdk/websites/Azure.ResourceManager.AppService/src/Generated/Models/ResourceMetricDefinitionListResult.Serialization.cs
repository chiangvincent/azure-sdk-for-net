// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class ResourceMetricDefinitionListResult
    {
        internal static ResourceMetricDefinitionListResult DeserializeResourceMetricDefinitionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ResourceMetricDefinition> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ResourceMetricDefinition> array = new List<ResourceMetricDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceMetricDefinition.DeserializeResourceMetricDefinition(item));
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
            return new ResourceMetricDefinitionListResult(value, nextLink.Value);
        }
    }
}
