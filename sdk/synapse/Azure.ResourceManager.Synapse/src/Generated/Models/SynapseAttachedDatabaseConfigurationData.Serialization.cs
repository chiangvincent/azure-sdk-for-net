// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseAttachedDatabaseConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(KustoPoolResourceId))
            {
                writer.WritePropertyName("clusterResourceId"u8);
                writer.WriteStringValue(KustoPoolResourceId);
            }
            if (Optional.IsDefined(DefaultPrincipalsModificationKind))
            {
                writer.WritePropertyName("defaultPrincipalsModificationKind"u8);
                writer.WriteStringValue(DefaultPrincipalsModificationKind.Value.ToString());
            }
            if (Optional.IsDefined(TableLevelSharingProperties))
            {
                writer.WritePropertyName("tableLevelSharingProperties"u8);
                writer.WriteObjectValue(TableLevelSharingProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseAttachedDatabaseConfigurationData DeserializeSynapseAttachedDatabaseConfigurationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<string> databaseName = default;
            Optional<ResourceIdentifier> clusterResourceId = default;
            Optional<IReadOnlyList<string>> attachedDatabaseNames = default;
            Optional<SynapseDefaultPrincipalsModificationKind> defaultPrincipalsModificationKind = default;
            Optional<SynapseTableLevelSharingProperties> tableLevelSharingProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("attachedDatabaseNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            attachedDatabaseNames = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultPrincipalsModificationKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultPrincipalsModificationKind = new SynapseDefaultPrincipalsModificationKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tableLevelSharingProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tableLevelSharingProperties = SynapseTableLevelSharingProperties.DeserializeSynapseTableLevelSharingProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseAttachedDatabaseConfigurationData(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(provisioningState), databaseName.Value, clusterResourceId.Value, Optional.ToList(attachedDatabaseNames), Optional.ToNullable(defaultPrincipalsModificationKind), tableLevelSharingProperties.Value);
        }
    }
}
