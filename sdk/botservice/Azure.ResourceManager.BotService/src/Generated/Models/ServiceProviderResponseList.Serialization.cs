// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    internal partial class ServiceProviderResponseList
    {
        internal static ServiceProviderResponseList DeserializeServiceProviderResponseList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BotServiceProvider>> value = default;
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
                    List<BotServiceProvider> array = new List<BotServiceProvider>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BotServiceProvider.DeserializeBotServiceProvider(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ServiceProviderResponseList(nextLink.Value, Optional.ToList(value));
        }
    }
}
