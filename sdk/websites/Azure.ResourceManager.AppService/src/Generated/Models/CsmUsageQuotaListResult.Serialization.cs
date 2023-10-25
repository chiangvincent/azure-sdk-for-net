// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class CsmUsageQuotaListResult
    {
        internal static CsmUsageQuotaListResult DeserializeCsmUsageQuotaListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CsmUsageQuota> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<CsmUsageQuota> array = new List<CsmUsageQuota>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CsmUsageQuota.DeserializeCsmUsageQuota(item));
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
            return new CsmUsageQuotaListResult(value, nextLink.Value);
        }
    }
}
