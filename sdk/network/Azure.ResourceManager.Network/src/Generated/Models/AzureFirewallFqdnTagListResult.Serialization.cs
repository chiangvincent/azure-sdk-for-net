// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class AzureFirewallFqdnTagListResult
    {
        internal static AzureFirewallFqdnTagListResult DeserializeAzureFirewallFqdnTagListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AzureFirewallFqdnTag>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureFirewallFqdnTag> array = new List<AzureFirewallFqdnTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureFirewallFqdnTag.DeserializeAzureFirewallFqdnTag(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AzureFirewallFqdnTagListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
