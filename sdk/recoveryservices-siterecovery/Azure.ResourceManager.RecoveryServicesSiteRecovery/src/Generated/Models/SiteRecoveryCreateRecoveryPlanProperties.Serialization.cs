// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryCreateRecoveryPlanProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("primaryFabricId"u8);
            writer.WriteStringValue(PrimaryFabricId);
            writer.WritePropertyName("recoveryFabricId"u8);
            writer.WriteStringValue(RecoveryFabricId);
            if (Optional.IsDefined(FailoverDeploymentModel))
            {
                writer.WritePropertyName("failoverDeploymentModel"u8);
                writer.WriteStringValue(FailoverDeploymentModel.Value.ToString());
            }
            writer.WritePropertyName("groups"u8);
            writer.WriteStartArray();
            foreach (var item in Groups)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ProviderSpecificContent))
            {
                writer.WritePropertyName("providerSpecificInput"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificContent)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
