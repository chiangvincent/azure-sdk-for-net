// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceSecret
    {
        internal static DataBoxEdgeDeviceSecret DeserializeDataBoxEdgeDeviceSecret(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AsymmetricEncryptedSecret> encryptedSecret = default;
            Optional<string> keyVaultId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptedSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptedSecret = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property.Value);
                    continue;
                }
                if (property.NameEquals("keyVaultId"u8))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
            }
            return new DataBoxEdgeDeviceSecret(encryptedSecret.Value, keyVaultId.Value);
        }
    }
}
