// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class HelmOperatorProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ChartVersion))
            {
                writer.WritePropertyName("chartVersion"u8);
                writer.WriteStringValue(ChartVersion);
            }
            if (Optional.IsDefined(ChartValues))
            {
                writer.WritePropertyName("chartValues"u8);
                writer.WriteStringValue(ChartValues);
            }
            writer.WriteEndObject();
        }

        internal static HelmOperatorProperties DeserializeHelmOperatorProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> chartVersion = default;
            Optional<string> chartValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("chartVersion"u8))
                {
                    chartVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chartValues"u8))
                {
                    chartValues = property.Value.GetString();
                    continue;
                }
            }
            return new HelmOperatorProperties(chartVersion.Value, chartValues.Value);
        }
    }
}
