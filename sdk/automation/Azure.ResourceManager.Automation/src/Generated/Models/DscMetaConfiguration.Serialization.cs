// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscMetaConfiguration
    {
        internal static DscMetaConfiguration DeserializeDscMetaConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> configurationModeFrequencyMins = default;
            Optional<bool> rebootNodeIfNeeded = default;
            Optional<string> configurationMode = default;
            Optional<string> actionAfterReboot = default;
            Optional<string> certificateId = default;
            Optional<int> refreshFrequencyMins = default;
            Optional<bool> allowModuleOverwrite = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationModeFrequencyMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationModeFrequencyMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rebootNodeIfNeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootNodeIfNeeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationMode"u8))
                {
                    configurationMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionAfterReboot"u8))
                {
                    actionAfterReboot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateId"u8))
                {
                    certificateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshFrequencyMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshFrequencyMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowModuleOverwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowModuleOverwrite = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DscMetaConfiguration(Optional.ToNullable(configurationModeFrequencyMins), Optional.ToNullable(rebootNodeIfNeeded), configurationMode.Value, actionAfterReboot.Value, certificateId.Value, Optional.ToNullable(refreshFrequencyMins), Optional.ToNullable(allowModuleOverwrite));
        }
    }
}
