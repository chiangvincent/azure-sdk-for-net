// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceWindow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule);
            writer.WritePropertyName("durationHours"u8);
            writer.WriteNumberValue(DurationHours);
            if (Optional.IsDefined(UtcOffset))
            {
                writer.WritePropertyName("utcOffset"u8);
                writer.WriteStringValue(UtcOffset);
            }
            if (Optional.IsDefined(StartDate))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartDate);
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime);
            if (Optional.IsCollectionDefined(NotAllowedDates))
            {
                writer.WritePropertyName("notAllowedDates"u8);
                writer.WriteStartArray();
                foreach (var item in NotAllowedDates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ContainerServiceMaintenanceWindow DeserializeContainerServiceMaintenanceWindow(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerServiceMaintenanceSchedule schedule = default;
            int durationHours = default;
            Optional<string> utcOffset = default;
            Optional<string> startDate = default;
            string startTime = default;
            Optional<IList<ContainerServiceDateSpan>> notAllowedDates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = ContainerServiceMaintenanceSchedule.DeserializeContainerServiceMaintenanceSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("durationHours"u8))
                {
                    durationHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utcOffset"u8))
                {
                    utcOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notAllowedDates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceDateSpan> array = new List<ContainerServiceDateSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceDateSpan.DeserializeContainerServiceDateSpan(item));
                    }
                    notAllowedDates = array;
                    continue;
                }
            }
            return new ContainerServiceMaintenanceWindow(schedule, durationHours, utcOffset.Value, startDate.Value, startTime, Optional.ToList(notAllowedDates));
        }
    }
}
