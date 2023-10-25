// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteOptimizedWaypoint
    {
        internal static RouteOptimizedWaypoint DeserializeRouteOptimizedWaypoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> providedIndex = default;
            Optional<int> optimizedIndex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providedIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providedIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("optimizedIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optimizedIndex = property.Value.GetInt32();
                    continue;
                }
            }
            return new RouteOptimizedWaypoint(Optional.ToNullable(providedIndex), Optional.ToNullable(optimizedIndex));
        }
    }
}
