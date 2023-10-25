// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineSizeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VCpusAvailable))
            {
                writer.WritePropertyName("vCPUsAvailable"u8);
                writer.WriteNumberValue(VCpusAvailable.Value);
            }
            if (Optional.IsDefined(VCpusPerCore))
            {
                writer.WritePropertyName("vCPUsPerCore"u8);
                writer.WriteNumberValue(VCpusPerCore.Value);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineSizeProperties DeserializeVirtualMachineSizeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> vCpusAvailable = default;
            Optional<int> vCpusPerCore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCPUsAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpusAvailable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vCPUsPerCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpusPerCore = property.Value.GetInt32();
                    continue;
                }
            }
            return new VirtualMachineSizeProperties(Optional.ToNullable(vCpusAvailable), Optional.ToNullable(vCpusPerCore));
        }
    }
}
