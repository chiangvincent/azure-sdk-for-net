// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DeviceIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(GenerationId))
            {
                writer.WritePropertyName("generationId"u8);
                writer.WriteStringValue(GenerationId);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StatusReason))
            {
                writer.WritePropertyName("statusReason"u8);
                writer.WriteStringValue(StatusReason);
            }
            if (Optional.IsDefined(ConnectionStateUpdatedTime))
            {
                writer.WritePropertyName("connectionStateUpdatedTime"u8);
                writer.WriteStringValue(ConnectionStateUpdatedTime.Value, "O");
            }
            if (Optional.IsDefined(StatusUpdatedTime))
            {
                writer.WritePropertyName("statusUpdatedTime"u8);
                writer.WriteStringValue(StatusUpdatedTime.Value, "O");
            }
            if (Optional.IsDefined(LastActivityTime))
            {
                writer.WritePropertyName("lastActivityTime"u8);
                writer.WriteStringValue(LastActivityTime.Value, "O");
            }
            if (Optional.IsDefined(CloudToDeviceMessageCount))
            {
                writer.WritePropertyName("cloudToDeviceMessageCount"u8);
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities);
            }
            if (Optional.IsDefined(DeviceScope))
            {
                writer.WritePropertyName("deviceScope"u8);
                writer.WriteStringValue(DeviceScope);
            }
            writer.WriteEndObject();
        }

        internal static DeviceIdentity DeserializeDeviceIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<string> generationId = default;
            Optional<string> etag = default;
            Optional<DeviceConnectionState> connectionState = default;
            Optional<DeviceStatus> status = default;
            Optional<string> statusReason = default;
            Optional<DateTimeOffset> connectionStateUpdatedTime = default;
            Optional<DateTimeOffset> statusUpdatedTime = default;
            Optional<DateTimeOffset> lastActivityTime = default;
            Optional<int> cloudToDeviceMessageCount = default;
            Optional<AuthenticationMechanism> authentication = default;
            Optional<DeviceCapabilities> capabilities = default;
            Optional<string> deviceScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generationId"u8))
                {
                    generationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new DeviceConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DeviceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"u8))
                {
                    statusReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStateUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStateUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = AuthenticationMechanism.DeserializeAuthenticationMechanism(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = DeviceCapabilities.DeserializeDeviceCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("deviceScope"u8))
                {
                    deviceScope = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceIdentity(deviceId.Value, generationId.Value, etag.Value, Optional.ToNullable(connectionState), Optional.ToNullable(status), statusReason.Value, Optional.ToNullable(connectionStateUpdatedTime), Optional.ToNullable(statusUpdatedTime), Optional.ToNullable(lastActivityTime), Optional.ToNullable(cloudToDeviceMessageCount), authentication.Value, capabilities.Value, deviceScope.Value);
        }
    }
}
