// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CustomRolloutStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CompletedRegions))
            {
                writer.WritePropertyName("completedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CompletedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FailedOrSkippedRegions))
            {
                writer.WritePropertyName("failedOrSkippedRegions"u8);
                writer.WriteStartObject();
                foreach (var item in FailedOrSkippedRegions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static CustomRolloutStatus DeserializeCustomRolloutStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AzureLocation>> completedRegions = default;
            Optional<IDictionary<string, ExtendedErrorInfo>> failedOrSkippedRegions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    completedRegions = array;
                    continue;
                }
                if (property.NameEquals("failedOrSkippedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExtendedErrorInfo> dictionary = new Dictionary<string, ExtendedErrorInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtendedErrorInfo.DeserializeExtendedErrorInfo(property0.Value));
                    }
                    failedOrSkippedRegions = dictionary;
                    continue;
                }
            }
            return new CustomRolloutStatus(Optional.ToList(completedRegions), Optional.ToDictionary(failedOrSkippedRegions));
        }
    }
}
