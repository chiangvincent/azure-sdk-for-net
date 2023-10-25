// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class DiagnosticCategoryListResult
    {
        internal static DiagnosticCategoryListResult DeserializeDiagnosticCategoryListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DiagnosticCategoryData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DiagnosticCategoryData> array = new List<DiagnosticCategoryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticCategoryData.DeserializeDiagnosticCategoryData(item));
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
            return new DiagnosticCategoryListResult(value, nextLink.Value);
        }
    }
}
