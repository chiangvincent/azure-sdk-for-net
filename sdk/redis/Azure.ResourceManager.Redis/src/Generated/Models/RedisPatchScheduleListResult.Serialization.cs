// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    internal partial class RedisPatchScheduleListResult
    {
        internal static RedisPatchScheduleListResult DeserializeRedisPatchScheduleListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RedisPatchScheduleData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RedisPatchScheduleData> array = new List<RedisPatchScheduleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisPatchScheduleData.DeserializeRedisPatchScheduleData(item));
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
            return new RedisPatchScheduleListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
