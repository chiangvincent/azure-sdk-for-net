// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FrontEndIPConfiguration))
            {
                writer.WritePropertyName("frontEndIPConfiguration"u8);
                writer.WriteObjectValue(FrontEndIPConfiguration);
            }
            if (Optional.IsDefined(NetworkInterfaceConfiguration))
            {
                writer.WritePropertyName("networkInterfaceConfiguration"u8);
                writer.WriteObjectValue(NetworkInterfaceConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static NginxNetworkProfile DeserializeNginxNetworkProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NginxFrontendIPConfiguration> frontEndIPConfiguration = default;
            Optional<NginxNetworkInterfaceConfiguration> networkInterfaceConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frontEndIPConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontEndIPConfiguration = NginxFrontendIPConfiguration.DeserializeNginxFrontendIPConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("networkInterfaceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkInterfaceConfiguration = NginxNetworkInterfaceConfiguration.DeserializeNginxNetworkInterfaceConfiguration(property.Value);
                    continue;
                }
            }
            return new NginxNetworkProfile(frontEndIPConfiguration.Value, networkInterfaceConfiguration.Value);
        }
    }
}
