// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    internal partial class ChannelResponseList
    {
        internal static ChannelResponseList DeserializeChannelResponseList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BotChannelData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BotChannelData> array = new List<BotChannelData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BotChannelData.DeserializeBotChannelData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ChannelResponseList(nextLink.Value, Optional.ToList(value));
        }
    }
}
