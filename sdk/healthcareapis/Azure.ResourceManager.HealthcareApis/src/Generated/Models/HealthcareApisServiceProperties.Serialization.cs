// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AccessPolicies))
            {
                writer.WritePropertyName("accessPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AccessPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CosmosDbConfiguration))
            {
                writer.WritePropertyName("cosmosDbConfiguration"u8);
                writer.WriteObjectValue(CosmosDbConfiguration);
            }
            if (Optional.IsDefined(AuthenticationConfiguration))
            {
                writer.WritePropertyName("authenticationConfiguration"u8);
                writer.WriteObjectValue(AuthenticationConfiguration);
            }
            if (Optional.IsDefined(CorsConfiguration))
            {
                writer.WritePropertyName("corsConfiguration"u8);
                writer.WriteObjectValue(CorsConfiguration);
            }
            if (Optional.IsDefined(ExportConfiguration))
            {
                writer.WritePropertyName("exportConfiguration"u8);
                writer.WriteObjectValue(ExportConfiguration);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(AcrConfiguration))
            {
                writer.WritePropertyName("acrConfiguration"u8);
                writer.WriteObjectValue(AcrConfiguration);
            }
            if (Optional.IsDefined(ImportConfiguration))
            {
                writer.WritePropertyName("importConfiguration"u8);
                writer.WriteObjectValue(ImportConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static HealthcareApisServiceProperties DeserializeHealthcareApisServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HealthcareApisProvisioningState> provisioningState = default;
            Optional<IList<HealthcareApisServiceAccessPolicyEntry>> accessPolicies = default;
            Optional<HealthcareApisServiceCosmosDbConfiguration> cosmosDbConfiguration = default;
            Optional<HealthcareApisServiceAuthenticationConfiguration> authenticationConfiguration = default;
            Optional<HealthcareApisServiceCorsConfiguration> corsConfiguration = default;
            Optional<ServiceExportConfigurationInfo> exportConfiguration = default;
            Optional<IList<HealthcareApisPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<HealthcareApisPublicNetworkAccess> publicNetworkAccess = default;
            Optional<HealthcareApisServiceAcrConfiguration> acrConfiguration = default;
            Optional<HealthcareApisServiceImportConfiguration> importConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HealthcareApisProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisServiceAccessPolicyEntry> array = new List<HealthcareApisServiceAccessPolicyEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisServiceAccessPolicyEntry.DeserializeHealthcareApisServiceAccessPolicyEntry(item));
                    }
                    accessPolicies = array;
                    continue;
                }
                if (property.NameEquals("cosmosDbConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cosmosDbConfiguration = HealthcareApisServiceCosmosDbConfiguration.DeserializeHealthcareApisServiceCosmosDbConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("authenticationConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationConfiguration = HealthcareApisServiceAuthenticationConfiguration.DeserializeHealthcareApisServiceAuthenticationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("corsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsConfiguration = HealthcareApisServiceCorsConfiguration.DeserializeHealthcareApisServiceCorsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("exportConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportConfiguration = ServiceExportConfigurationInfo.DeserializeServiceExportConfigurationInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisPrivateEndpointConnectionData> array = new List<HealthcareApisPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HealthcareApisPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acrConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acrConfiguration = HealthcareApisServiceAcrConfiguration.DeserializeHealthcareApisServiceAcrConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("importConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importConfiguration = HealthcareApisServiceImportConfiguration.DeserializeHealthcareApisServiceImportConfiguration(property.Value);
                    continue;
                }
            }
            return new HealthcareApisServiceProperties(Optional.ToNullable(provisioningState), Optional.ToList(accessPolicies), cosmosDbConfiguration.Value, authenticationConfiguration.Value, corsConfiguration.Value, exportConfiguration.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess), acrConfiguration.Value, importConfiguration.Value);
        }
    }
}
