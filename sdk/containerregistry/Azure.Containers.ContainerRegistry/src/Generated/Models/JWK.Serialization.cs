// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class JWK
    {
        internal static JWK DeserializeJWK(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JWKHeader> jwk = default;
            Optional<string> alg = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jwk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jwk = JWKHeader.DeserializeJWKHeader(property.Value);
                    continue;
                }
                if (property.NameEquals("alg"u8))
                {
                    alg = property.Value.GetString();
                    continue;
                }
            }
            return new JWK(jwk.Value, alg.Value);
        }
    }
}
