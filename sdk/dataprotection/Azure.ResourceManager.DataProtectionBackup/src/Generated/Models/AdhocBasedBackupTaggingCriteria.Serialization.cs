// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class AdhocBasedBackupTaggingCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TagInfo))
            {
                writer.WritePropertyName("tagInfo"u8);
                writer.WriteObjectValue(TagInfo);
            }
            writer.WriteEndObject();
        }

        internal static AdhocBasedBackupTaggingCriteria DeserializeAdhocBasedBackupTaggingCriteria(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataProtectionBackupRetentionTag> tagInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tagInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagInfo = DataProtectionBackupRetentionTag.DeserializeDataProtectionBackupRetentionTag(property.Value);
                    continue;
                }
            }
            return new AdhocBasedBackupTaggingCriteria(tagInfo.Value);
        }
    }
}
