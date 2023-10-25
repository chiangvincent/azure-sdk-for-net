// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ReportProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferGuid))
            {
                writer.WritePropertyName("offerGuid"u8);
                writer.WriteStringValue(OfferGuid);
            }
            writer.WritePropertyName("timeZone"u8);
            writer.WriteStringValue(TimeZone);
            writer.WritePropertyName("triggerTime"u8);
            writer.WriteStringValue(TriggerOn, "O");
            writer.WritePropertyName("resources"u8);
            writer.WriteStartArray();
            foreach (var item in Resources)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ReportProperties DeserializeReportProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<ReportStatus> status = default;
            Optional<Guid> tenantId = default;
            Optional<string> reportName = default;
            Optional<string> offerGuid = default;
            string timeZone = default;
            DateTimeOffset triggerTime = default;
            Optional<DateTimeOffset> nextTriggerTime = default;
            Optional<DateTimeOffset> lastTriggerTime = default;
            Optional<IReadOnlyList<string>> subscriptions = default;
            IList<ResourceMetadata> resources = default;
            Optional<ReportComplianceStatus> complianceStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ReportStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("reportName"u8))
                {
                    reportName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerGuid"u8))
                {
                    offerGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerTime"u8))
                {
                    triggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("nextTriggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTriggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTriggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTriggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    List<ResourceMetadata> array = new List<ResourceMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceMetadata.DeserializeResourceMetadata(item));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = ReportComplianceStatus.DeserializeReportComplianceStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new ReportProperties(id.Value, Optional.ToNullable(status), Optional.ToNullable(tenantId), reportName.Value, offerGuid.Value, timeZone, triggerTime, Optional.ToNullable(nextTriggerTime), Optional.ToNullable(lastTriggerTime), Optional.ToList(subscriptions), resources, complianceStatus.Value, Optional.ToNullable(provisioningState));
        }
    }
}
