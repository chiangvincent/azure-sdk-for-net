// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class UnknownTriggerContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static UnknownTriggerContext DeserializeUnknownTriggerContext(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string objectType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownTriggerContext(objectType);
        }
    }
}
