// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2ProtectedDiskDetails
    {
        internal static InMageAzureV2ProtectedDiskDetails DeserializeInMageAzureV2ProtectedDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<string> protectionStage = default;
            Optional<string> healthErrorCode = default;
            Optional<long> rpoInSeconds = default;
            Optional<string> resyncRequired = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<long> resyncDurationInSeconds = default;
            Optional<long> diskCapacityInBytes = default;
            Optional<long> fileSystemCapacityInBytes = default;
            Optional<double> sourceDataInMegaBytes = default;
            Optional<double> psDataInMegaBytes = default;
            Optional<double> targetDataInMegaBytes = default;
            Optional<string> diskResized = default;
            Optional<DateTimeOffset> lastRpoCalculatedTime = default;
            Optional<long> resyncProcessedBytes = default;
            Optional<long> resyncTotalTransferredBytes = default;
            Optional<long> resyncLast15MinutesTransferredBytes = default;
            Optional<DateTimeOffset> resyncLastDataTransferTimeUTC = default;
            Optional<DateTimeOffset> resyncStartTime = default;
            Optional<string> progressHealth = default;
            Optional<string> progressStatus = default;
            Optional<long> secondsToTakeSwitchProvider = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStage"u8))
                {
                    protectionStage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrorCode"u8))
                {
                    healthErrorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncDurationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDurationInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskCapacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCapacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fileSystemCapacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSystemCapacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sourceDataInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceDataInMegaBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("psDataInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    psDataInMegaBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("targetDataInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDataInMegaBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("diskResized"u8))
                {
                    diskResized = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resyncProcessedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncTotalTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncTotalTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncLast15MinutesTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncLast15MinutesTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncLastDataTransferTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncLastDataTransferTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resyncStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("progressHealth"u8))
                {
                    progressHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressStatus"u8))
                {
                    progressStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondsToTakeSwitchProvider"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondsToTakeSwitchProvider = property.Value.GetInt64();
                    continue;
                }
            }
            return new InMageAzureV2ProtectedDiskDetails(diskId.Value, diskName.Value, protectionStage.Value, healthErrorCode.Value, Optional.ToNullable(rpoInSeconds), resyncRequired.Value, Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resyncDurationInSeconds), Optional.ToNullable(diskCapacityInBytes), Optional.ToNullable(fileSystemCapacityInBytes), Optional.ToNullable(sourceDataInMegaBytes), Optional.ToNullable(psDataInMegaBytes), Optional.ToNullable(targetDataInMegaBytes), diskResized.Value, Optional.ToNullable(lastRpoCalculatedTime), Optional.ToNullable(resyncProcessedBytes), Optional.ToNullable(resyncTotalTransferredBytes), Optional.ToNullable(resyncLast15MinutesTransferredBytes), Optional.ToNullable(resyncLastDataTransferTimeUTC), Optional.ToNullable(resyncStartTime), progressHealth.Value, progressStatus.Value, Optional.ToNullable(secondsToTakeSwitchProvider));
        }
    }
}
