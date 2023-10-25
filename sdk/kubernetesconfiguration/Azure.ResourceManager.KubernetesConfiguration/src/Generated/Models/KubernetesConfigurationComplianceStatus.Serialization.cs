// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesConfigurationComplianceStatus
    {
        internal static KubernetesConfigurationComplianceStatus DeserializeKubernetesConfigurationComplianceStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KubernetesConfigurationComplianceStateType> complianceState = default;
            Optional<DateTimeOffset> lastConfigApplied = default;
            Optional<string> message = default;
            Optional<KubernetesConfigurationMesageLevel> messageLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceState = new KubernetesConfigurationComplianceStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastConfigApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConfigApplied = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageLevel = new KubernetesConfigurationMesageLevel(property.Value.GetString());
                    continue;
                }
            }
            return new KubernetesConfigurationComplianceStatus(Optional.ToNullable(complianceState), Optional.ToNullable(lastConfigApplied), message.Value, Optional.ToNullable(messageLevel));
        }
    }
}
