// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class PeeringExchangeConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringDBFacilityId))
            {
                writer.WritePropertyName("peeringDBFacilityId"u8);
                writer.WriteNumberValue(PeeringDBFacilityId.Value);
            }
            if (Optional.IsDefined(BgpSession))
            {
                writer.WritePropertyName("bgpSession"u8);
                writer.WriteObjectValue(BgpSession);
            }
            if (Optional.IsDefined(ConnectionIdentifier))
            {
                writer.WritePropertyName("connectionIdentifier"u8);
                writer.WriteStringValue(ConnectionIdentifier.Value);
            }
            writer.WriteEndObject();
        }

        internal static PeeringExchangeConnection DeserializePeeringExchangeConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> peeringDBFacilityId = default;
            Optional<PeeringConnectionState> connectionState = default;
            Optional<PeeringBgpSession> bgpSession = default;
            Optional<Guid> connectionIdentifier = default;
            Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringDBFacilityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringDBFacilityId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new PeeringConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bgpSession"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpSession = PeeringBgpSession.DeserializePeeringBgpSession(property.Value);
                    continue;
                }
                if (property.NameEquals("connectionIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionIdentifier = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new PeeringExchangeConnection(Optional.ToNullable(peeringDBFacilityId), Optional.ToNullable(connectionState), bgpSession.Value, Optional.ToNullable(connectionIdentifier), errorMessage.Value);
        }
    }
}
