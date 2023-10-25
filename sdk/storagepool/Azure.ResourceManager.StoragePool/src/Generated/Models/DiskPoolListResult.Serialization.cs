// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    internal partial class DiskPoolListResult
    {
        internal static DiskPoolListResult DeserializeDiskPoolListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DiskPoolData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DiskPoolData> array = new List<DiskPoolData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskPoolData.DeserializeDiskPoolData(item));
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
            return new DiskPoolListResult(value, nextLink.Value);
        }
    }
}
