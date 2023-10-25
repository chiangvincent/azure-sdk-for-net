// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformCustomDomainProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (Optional.IsDefined(CertName))
            {
                writer.WritePropertyName("certName"u8);
                writer.WriteStringValue(CertName);
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformCustomDomainProperties DeserializeAppPlatformCustomDomainProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> thumbprint = default;
            Optional<string> appName = default;
            Optional<string> certName = default;
            Optional<AppPlatformCustomDomainProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appName"u8))
                {
                    appName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certName"u8))
                {
                    certName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformCustomDomainProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AppPlatformCustomDomainProperties(thumbprint.Value, appName.Value, certName.Value, Optional.ToNullable(provisioningState));
        }
    }
}
