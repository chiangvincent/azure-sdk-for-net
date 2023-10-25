// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class CanceledSubscriptionId
    {
        internal static CanceledSubscriptionId DeserializeCanceledSubscriptionId(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new CanceledSubscriptionId(subscriptionId.Value);
        }
    }
}
