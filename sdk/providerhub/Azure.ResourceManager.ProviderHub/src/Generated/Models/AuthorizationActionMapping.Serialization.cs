// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class AuthorizationActionMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Original))
            {
                writer.WritePropertyName("original"u8);
                writer.WriteStringValue(Original);
            }
            if (Optional.IsDefined(Desired))
            {
                writer.WritePropertyName("desired"u8);
                writer.WriteStringValue(Desired);
            }
            writer.WriteEndObject();
        }

        internal static AuthorizationActionMapping DeserializeAuthorizationActionMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> original = default;
            Optional<string> desired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("original"u8))
                {
                    original = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("desired"u8))
                {
                    desired = property.Value.GetString();
                    continue;
                }
            }
            return new AuthorizationActionMapping(original.Value, desired.Value);
        }
    }
}
