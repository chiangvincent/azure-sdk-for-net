// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAutoUpgradeProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UpgradeChannel))
            {
                writer.WritePropertyName("upgradeChannel"u8);
                writer.WriteStringValue(UpgradeChannel.Value.ToString());
            }
            if (Optional.IsDefined(NodeOSUpgradeChannel))
            {
                writer.WritePropertyName("nodeOSUpgradeChannel"u8);
                writer.WriteStringValue(NodeOSUpgradeChannel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAutoUpgradeProfile DeserializeManagedClusterAutoUpgradeProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UpgradeChannel> upgradeChannel = default;
            Optional<ManagedClusterNodeOSUpgradeChannel> nodeOSUpgradeChannel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("upgradeChannel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeChannel = new UpgradeChannel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeOSUpgradeChannel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeOSUpgradeChannel = new ManagedClusterNodeOSUpgradeChannel(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterAutoUpgradeProfile(Optional.ToNullable(upgradeChannel), Optional.ToNullable(nodeOSUpgradeChannel));
        }
    }
}
