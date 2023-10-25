// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class ExternalStorageInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageType"u8);
            writer.WriteStringValue(StorageType.ToString());
            if (Optional.IsDefined(BlobStorage))
            {
                writer.WritePropertyName("blobStorage"u8);
                writer.WriteObjectValue(BlobStorage);
            }
            writer.WriteEndObject();
        }
    }
}
