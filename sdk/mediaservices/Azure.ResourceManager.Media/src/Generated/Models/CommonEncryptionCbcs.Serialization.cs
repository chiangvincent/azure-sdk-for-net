// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class CommonEncryptionCbcs : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledProtocols))
            {
                writer.WritePropertyName("enabledProtocols"u8);
                writer.WriteObjectValue(EnabledProtocols);
            }
            if (Optional.IsCollectionDefined(ClearTracks))
            {
                writer.WritePropertyName("clearTracks"u8);
                writer.WriteStartArray();
                foreach (var item in ClearTracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteObjectValue(ContentKeys);
            }
            if (Optional.IsDefined(Drm))
            {
                writer.WritePropertyName("drm"u8);
                writer.WriteObjectValue(Drm);
            }
            if (Optional.IsDefined(ClearKeyEncryptionConfiguration))
            {
                writer.WritePropertyName("clearKeyEncryptionConfiguration"u8);
                writer.WriteObjectValue(ClearKeyEncryptionConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static CommonEncryptionCbcs DeserializeCommonEncryptionCbcs(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaEnabledProtocols> enabledProtocols = default;
            Optional<IList<MediaTrackSelection>> clearTracks = default;
            Optional<StreamingPolicyContentKeys> contentKeys = default;
            Optional<CbcsDrmConfiguration> drm = default;
            Optional<ClearKeyEncryptionConfiguration> clearKeyEncryptionConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledProtocols = MediaEnabledProtocols.DeserializeMediaEnabledProtocols(property.Value);
                    continue;
                }
                if (property.NameEquals("clearTracks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaTrackSelection> array = new List<MediaTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTrackSelection.DeserializeMediaTrackSelection(item));
                    }
                    clearTracks = array;
                    continue;
                }
                if (property.NameEquals("contentKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentKeys = StreamingPolicyContentKeys.DeserializeStreamingPolicyContentKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("drm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    drm = CbcsDrmConfiguration.DeserializeCbcsDrmConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("clearKeyEncryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clearKeyEncryptionConfiguration = ClearKeyEncryptionConfiguration.DeserializeClearKeyEncryptionConfiguration(property.Value);
                    continue;
                }
            }
            return new CommonEncryptionCbcs(enabledProtocols.Value, Optional.ToList(clearTracks), contentKeys.Value, drm.Value, clearKeyEncryptionConfiguration.Value);
        }
    }
}
