// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterVerticalPodAutoscaler : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("controlledValues"u8);
            writer.WriteStringValue(ControlledValues.ToString());
            writer.WritePropertyName("updateMode"u8);
            writer.WriteStringValue(UpdateMode.ToString());
            writer.WriteEndObject();
        }

        internal static ManagedClusterVerticalPodAutoscaler DeserializeManagedClusterVerticalPodAutoscaler(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            ManagedClusterWorkloadAutoScalerControlledValue controlledValues = default;
            ManagedClusterVerticalPodAutoscalerUpdateMode updateMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("controlledValues"u8))
                {
                    controlledValues = new ManagedClusterWorkloadAutoScalerControlledValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateMode"u8))
                {
                    updateMode = new ManagedClusterVerticalPodAutoscalerUpdateMode(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterVerticalPodAutoscaler(enabled, controlledValues, updateMode);
        }
    }
}
