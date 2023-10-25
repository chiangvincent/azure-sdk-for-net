// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class SubnetSharedPublicIPAddressConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedPorts))
            {
                writer.WritePropertyName("allowedPorts"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedPorts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SubnetSharedPublicIPAddressConfiguration DeserializeSubnetSharedPublicIPAddressConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DevTestLabPort>> allowedPorts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabPort> array = new List<DevTestLabPort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabPort.DeserializeDevTestLabPort(item));
                    }
                    allowedPorts = array;
                    continue;
                }
            }
            return new SubnetSharedPublicIPAddressConfiguration(Optional.ToList(allowedPorts));
        }
    }
}
