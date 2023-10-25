// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class FrontDoorSecretProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static FrontDoorSecretProperties DeserializeFrontDoorSecretProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFirstPartyManagedCertificate": return AzureFirstPartyManagedCertificateProperties.DeserializeAzureFirstPartyManagedCertificateProperties(element);
                    case "CustomerCertificate": return CustomerCertificateProperties.DeserializeCustomerCertificateProperties(element);
                    case "ManagedCertificate": return ManagedCertificateProperties.DeserializeManagedCertificateProperties(element);
                    case "UrlSigningKey": return UriSigningKeyProperties.DeserializeUriSigningKeyProperties(element);
                }
            }
            return UnknownSecretProperties.DeserializeUnknownSecretProperties(element);
        }
    }
}
