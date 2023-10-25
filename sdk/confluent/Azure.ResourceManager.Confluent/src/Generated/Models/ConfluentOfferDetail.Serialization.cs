// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ConfluentOfferDetail : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("publisherId"u8);
            writer.WriteStringValue(PublisherId);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("planId"u8);
            writer.WriteStringValue(PlanId);
            writer.WritePropertyName("planName"u8);
            writer.WriteStringValue(PlanName);
            writer.WritePropertyName("termUnit"u8);
            writer.WriteStringValue(TermUnit);
            writer.WriteEndObject();
        }

        internal static ConfluentOfferDetail DeserializeConfluentOfferDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publisherId = default;
            string id = default;
            string planId = default;
            string planName = default;
            string termUnit = default;
            Optional<ConfluentSaaSOfferStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planName"u8))
                {
                    planName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termUnit"u8))
                {
                    termUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ConfluentSaaSOfferStatus(property.Value.GetString());
                    continue;
                }
            }
            return new ConfluentOfferDetail(publisherId, id, planId, planName, termUnit, Optional.ToNullable(status));
        }
    }
}
