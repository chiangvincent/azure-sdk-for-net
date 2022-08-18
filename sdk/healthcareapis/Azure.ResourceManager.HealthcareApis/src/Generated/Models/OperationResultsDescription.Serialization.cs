// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class OperationResultsDescription
    {
        internal static OperationResultsDescription DeserializeOperationResultsDescription(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<OperationResultStatus> status = default;
            Optional<string> startTime = default;
            Optional<string> endTime = default;
            Optional<BinaryData> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new OperationResultStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new OperationResultsDescription(id.Value, name.Value, Optional.ToNullable(status), startTime.Value, endTime.Value, properties.Value);
        }
    }
}
