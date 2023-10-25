// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    internal partial class ContainerRegistryAgentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu"u8);
                writer.WriteNumberValue(Cpu.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryAgentProperties DeserializeContainerRegistryAgentProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> cpu = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpu = property.Value.GetInt32();
                    continue;
                }
            }
            return new ContainerRegistryAgentProperties(Optional.ToNullable(cpu));
        }
    }
}
