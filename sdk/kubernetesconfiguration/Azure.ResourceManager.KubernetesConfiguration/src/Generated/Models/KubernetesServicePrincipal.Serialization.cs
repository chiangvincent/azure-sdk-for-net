// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesServicePrincipal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Optional.IsDefined(TenantId))
            {
                if (TenantId != null)
                {
                    writer.WritePropertyName("tenantId"u8);
                    writer.WriteStringValue(TenantId.Value);
                }
                else
                {
                    writer.WriteNull("tenantId");
                }
            }
            if (Optional.IsDefined(ClientSecret))
            {
                if (ClientSecret != null)
                {
                    writer.WritePropertyName("clientSecret"u8);
                    writer.WriteStringValue(ClientSecret);
                }
                else
                {
                    writer.WriteNull("clientSecret");
                }
            }
            if (Optional.IsDefined(ClientCertificate))
            {
                if (ClientCertificate != null)
                {
                    writer.WritePropertyName("clientCertificate"u8);
                    writer.WriteStringValue(ClientCertificate);
                }
                else
                {
                    writer.WriteNull("clientCertificate");
                }
            }
            if (Optional.IsDefined(ClientCertificatePassword))
            {
                if (ClientCertificatePassword != null)
                {
                    writer.WritePropertyName("clientCertificatePassword"u8);
                    writer.WriteStringValue(ClientCertificatePassword);
                }
                else
                {
                    writer.WriteNull("clientCertificatePassword");
                }
            }
            if (Optional.IsDefined(ClientCertificateSendChain))
            {
                writer.WritePropertyName("clientCertificateSendChain"u8);
                writer.WriteBooleanValue(ClientCertificateSendChain.Value);
            }
            writer.WriteEndObject();
        }

        internal static KubernetesServicePrincipal DeserializeKubernetesServicePrincipal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid?> clientId = default;
            Optional<Guid?> tenantId = default;
            Optional<string> clientSecret = default;
            Optional<string> clientCertificate = default;
            Optional<string> clientCertificatePassword = default;
            Optional<bool> clientCertificateSendChain = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tenantId = null;
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientSecret = null;
                        continue;
                    }
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientCertificate = null;
                        continue;
                    }
                    clientCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificatePassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientCertificatePassword = null;
                        continue;
                    }
                    clientCertificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificateSendChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCertificateSendChain = property.Value.GetBoolean();
                    continue;
                }
            }
            return new KubernetesServicePrincipal(Optional.ToNullable(clientId), Optional.ToNullable(tenantId), clientSecret.Value, clientCertificate.Value, clientCertificatePassword.Value, Optional.ToNullable(clientCertificateSendChain));
        }
    }
}
