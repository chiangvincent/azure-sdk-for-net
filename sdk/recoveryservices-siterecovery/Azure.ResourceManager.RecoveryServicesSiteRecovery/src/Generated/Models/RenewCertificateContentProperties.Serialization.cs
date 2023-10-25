// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class RenewCertificateContentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RenewCertificateType))
            {
                writer.WritePropertyName("renewCertificateType"u8);
                writer.WriteStringValue(RenewCertificateType);
            }
            writer.WriteEndObject();
        }
    }
}
