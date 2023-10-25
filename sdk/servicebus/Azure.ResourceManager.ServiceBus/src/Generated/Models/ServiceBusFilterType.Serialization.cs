// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceBus.Models
{
    internal static partial class ServiceBusFilterTypeExtensions
    {
        public static string ToSerialString(this ServiceBusFilterType value) => value switch
        {
            ServiceBusFilterType.SqlFilter => "SqlFilter",
            ServiceBusFilterType.CorrelationFilter => "CorrelationFilter",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusFilterType value.")
        };

        public static ServiceBusFilterType ToServiceBusFilterType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SqlFilter")) return ServiceBusFilterType.SqlFilter;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CorrelationFilter")) return ServiceBusFilterType.CorrelationFilter;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusFilterType value.");
        }
    }
}
