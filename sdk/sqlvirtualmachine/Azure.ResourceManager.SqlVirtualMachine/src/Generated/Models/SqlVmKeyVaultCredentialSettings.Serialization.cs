// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmKeyVaultCredentialSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CredentialName))
            {
                writer.WritePropertyName("credentialName"u8);
                writer.WriteStringValue(CredentialName);
            }
            if (Optional.IsDefined(AzureKeyVaultUri))
            {
                writer.WritePropertyName("azureKeyVaultUrl"u8);
                writer.WriteStringValue(AzureKeyVaultUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ServicePrincipalName))
            {
                writer.WritePropertyName("servicePrincipalName"u8);
                writer.WriteStringValue(ServicePrincipalName);
            }
            if (Optional.IsDefined(ServicePrincipalSecret))
            {
                writer.WritePropertyName("servicePrincipalSecret"u8);
                writer.WriteStringValue(ServicePrincipalSecret);
            }
            writer.WriteEndObject();
        }

        internal static SqlVmKeyVaultCredentialSettings DeserializeSqlVmKeyVaultCredentialSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enable = default;
            Optional<string> credentialName = default;
            Optional<Uri> azureKeyVaultUrl = default;
            Optional<string> servicePrincipalName = default;
            Optional<string> servicePrincipalSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("credentialName"u8))
                {
                    credentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureKeyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureKeyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("servicePrincipalName"u8))
                {
                    servicePrincipalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalSecret"u8))
                {
                    servicePrincipalSecret = property.Value.GetString();
                    continue;
                }
            }
            return new SqlVmKeyVaultCredentialSettings(Optional.ToNullable(enable), credentialName.Value, azureKeyVaultUrl.Value, servicePrincipalName.Value, servicePrincipalSecret.Value);
        }
    }
}
