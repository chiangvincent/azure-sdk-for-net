// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DataMigrationServiceStatusResponse
    {
        internal static DataMigrationServiceStatusResponse DeserializeDataMigrationServiceStatusResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentVersion = default;
            Optional<BinaryData> agentConfiguration = default;
            Optional<string> status = default;
            Optional<string> vmSize = default;
            Optional<IReadOnlyList<string>> supportedTaskTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedTaskTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedTaskTypes = array;
                    continue;
                }
            }
            return new DataMigrationServiceStatusResponse(agentVersion.Value, agentConfiguration.Value, status.Value, vmSize.Value, Optional.ToList(supportedTaskTypes));
        }
    }
}
