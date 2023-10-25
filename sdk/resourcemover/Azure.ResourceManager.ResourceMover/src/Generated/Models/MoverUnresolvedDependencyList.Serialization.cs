// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoverUnresolvedDependencyList
    {
        internal static MoverUnresolvedDependencyList DeserializeMoverUnresolvedDependencyList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MoverUnresolvedDependency>> value = default;
            Optional<string> nextLink = default;
            Optional<MoverSummaryList> summaryCollection = default;
            Optional<long> totalCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverUnresolvedDependency> array = new List<MoverUnresolvedDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverUnresolvedDependency.DeserializeMoverUnresolvedDependency(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summaryCollection = MoverSummaryList.DeserializeMoverSummaryList(property.Value);
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new MoverUnresolvedDependencyList(Optional.ToList(value), nextLink.Value, summaryCollection.Value, Optional.ToNullable(totalCount));
        }
    }
}
