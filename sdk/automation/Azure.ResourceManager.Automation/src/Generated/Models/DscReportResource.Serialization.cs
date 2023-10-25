// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscReportResource
    {
        internal static DscReportResource DeserializeDscReportResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<string> sourceInfo = default;
            Optional<IReadOnlyList<DscReportResourceNavigation>> dependsOn = default;
            Optional<string> moduleName = default;
            Optional<string> moduleVersion = default;
            Optional<string> resourceName = default;
            Optional<string> error = default;
            Optional<string> status = default;
            Optional<double> durationInSeconds = default;
            Optional<DateTimeOffset> startDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceInfo"u8))
                {
                    sourceInfo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportResourceNavigation> array = new List<DscReportResourceNavigation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResourceNavigation.DeserializeDscReportResourceNavigation(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("moduleName"u8))
                {
                    moduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleVersion"u8))
                {
                    moduleVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DscReportResource(resourceId.Value, sourceInfo.Value, Optional.ToList(dependsOn), moduleName.Value, moduleVersion.Value, resourceName.Value, error.Value, status.Value, Optional.ToNullable(durationInSeconds), Optional.ToNullable(startDate));
        }
    }
}
