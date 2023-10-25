// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class ComplianceDetail
    {
        internal static ComplianceDetail DeserializeComplianceDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> complianceState = default;
            Optional<int> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
            }
            return new ComplianceDetail(complianceState.Value, Optional.ToNullable(count));
        }
    }
}
