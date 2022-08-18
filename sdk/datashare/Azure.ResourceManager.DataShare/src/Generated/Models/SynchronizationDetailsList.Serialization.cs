// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    internal partial class SynchronizationDetailsList
    {
        internal static SynchronizationDetailsList DeserializeSynchronizationDetailsList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<SynchronizationDetails> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<SynchronizationDetails> array = new List<SynchronizationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynchronizationDetails.DeserializeSynchronizationDetails(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SynchronizationDetailsList(nextLink.Value, value);
        }
    }
}
