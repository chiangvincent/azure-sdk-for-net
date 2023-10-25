// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    internal static partial class QueryStringCachingBehaviorExtensions
    {
        public static string ToSerialString(this QueryStringCachingBehavior value) => value switch
        {
            QueryStringCachingBehavior.NotSet => "NotSet",
            QueryStringCachingBehavior.IgnoreQueryString => "IgnoreQueryString",
            QueryStringCachingBehavior.BypassCaching => "BypassCaching",
            QueryStringCachingBehavior.UseQueryString => "UseQueryString",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryStringCachingBehavior value.")
        };

        public static QueryStringCachingBehavior ToQueryStringCachingBehavior(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSet")) return QueryStringCachingBehavior.NotSet;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IgnoreQueryString")) return QueryStringCachingBehavior.IgnoreQueryString;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "BypassCaching")) return QueryStringCachingBehavior.BypassCaching;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "UseQueryString")) return QueryStringCachingBehavior.UseQueryString;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryStringCachingBehavior value.");
        }
    }
}
