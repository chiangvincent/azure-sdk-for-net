// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupResourceVaultConfigProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageModelType))
            {
                writer.WritePropertyName("storageModelType"u8);
                writer.WriteStringValue(StorageModelType.Value.ToString());
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (Optional.IsDefined(StorageTypeState))
            {
                writer.WritePropertyName("storageTypeState"u8);
                writer.WriteStringValue(StorageTypeState.Value.ToString());
            }
            if (Optional.IsDefined(EnhancedSecurityState))
            {
                writer.WritePropertyName("enhancedSecurityState"u8);
                writer.WriteStringValue(EnhancedSecurityState.Value.ToString());
            }
            if (Optional.IsDefined(SoftDeleteFeatureState))
            {
                writer.WritePropertyName("softDeleteFeatureState"u8);
                writer.WriteStringValue(SoftDeleteFeatureState.Value.ToString());
            }
            if (Optional.IsDefined(SoftDeleteRetentionPeriodInDays))
            {
                writer.WritePropertyName("softDeleteRetentionPeriodInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriodInDays.Value);
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsSoftDeleteFeatureStateEditable))
            {
                writer.WritePropertyName("isSoftDeleteFeatureStateEditable"u8);
                writer.WriteBooleanValue(IsSoftDeleteFeatureStateEditable.Value);
            }
            writer.WriteEndObject();
        }

        internal static BackupResourceVaultConfigProperties DeserializeBackupResourceVaultConfigProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupStorageType> storageModelType = default;
            Optional<BackupStorageType> storageType = default;
            Optional<BackupStorageTypeState> storageTypeState = default;
            Optional<EnhancedSecurityState> enhancedSecurityState = default;
            Optional<SoftDeleteFeatureState> softDeleteFeatureState = default;
            Optional<int> softDeleteRetentionPeriodInDays = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<bool> isSoftDeleteFeatureStateEditable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageModelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageModelType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageTypeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageTypeState = new BackupStorageTypeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enhancedSecurityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enhancedSecurityState = new EnhancedSecurityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softDeleteFeatureState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteFeatureState = new SoftDeleteFeatureState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isSoftDeleteFeatureStateEditable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSoftDeleteFeatureStateEditable = property.Value.GetBoolean();
                    continue;
                }
            }
            return new BackupResourceVaultConfigProperties(Optional.ToNullable(storageModelType), Optional.ToNullable(storageType), Optional.ToNullable(storageTypeState), Optional.ToNullable(enhancedSecurityState), Optional.ToNullable(softDeleteFeatureState), Optional.ToNullable(softDeleteRetentionPeriodInDays), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isSoftDeleteFeatureStateEditable));
        }
    }
}
