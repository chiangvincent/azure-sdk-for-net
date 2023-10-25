// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    internal partial class HttpProxyConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HttpsProxy))
            {
                writer.WritePropertyName("httpsProxy"u8);
                writer.WriteStringValue(HttpsProxy);
            }
            writer.WriteEndObject();
        }

        internal static HttpProxyConfiguration DeserializeHttpProxyConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> httpsProxy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpsProxy"u8))
                {
                    httpsProxy = property.Value.GetString();
                    continue;
                }
            }
            return new HttpProxyConfiguration(httpsProxy.Value);
        }
    }
}
