// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    internal partial class ShareSubscriptionSynchronizationList
    {
        internal static ShareSubscriptionSynchronizationList DeserializeShareSubscriptionSynchronizationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<ShareSubscriptionSynchronization> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<ShareSubscriptionSynchronization> array = new List<ShareSubscriptionSynchronization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShareSubscriptionSynchronization.DeserializeShareSubscriptionSynchronization(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ShareSubscriptionSynchronizationList(nextLink.Value, value);
        }
    }
}
