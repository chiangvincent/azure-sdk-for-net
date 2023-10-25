// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StatusCodesRangeBasedTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StatusCodes))
            {
                writer.WritePropertyName("statusCodes"u8);
                writer.WriteStringValue(StatusCodes);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(TimeInterval))
            {
                writer.WritePropertyName("timeInterval"u8);
                writer.WriteStringValue(TimeInterval);
            }
            writer.WriteEndObject();
        }

        internal static StatusCodesRangeBasedTrigger DeserializeStatusCodesRangeBasedTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> statusCodes = default;
            Optional<string> path = default;
            Optional<int> count = default;
            Optional<string> timeInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCodes"u8))
                {
                    statusCodes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeInterval"u8))
                {
                    timeInterval = property.Value.GetString();
                    continue;
                }
            }
            return new StatusCodesRangeBasedTrigger(statusCodes.Value, path.Value, Optional.ToNullable(count), timeInterval.Value);
        }
    }
}
