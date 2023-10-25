// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OutputType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(OutputType.Value.ToString());
            }
            if (Optional.IsDefined(WorkspaceSettings))
            {
                writer.WritePropertyName("workspaceSettings"u8);
                writer.WriteObjectValue(WorkspaceSettings);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorOutput DeserializeConnectionMonitorOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OutputType> type = default;
            Optional<ConnectionMonitorWorkspaceSettings> workspaceSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workspaceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceSettings = ConnectionMonitorWorkspaceSettings.DeserializeConnectionMonitorWorkspaceSettings(property.Value);
                    continue;
                }
            }
            return new ConnectionMonitorOutput(Optional.ToNullable(type), workspaceSettings.Value);
        }
    }
}
