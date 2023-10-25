// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    internal static partial class IndexActionTypeExtensions
    {
        public static string ToSerialString(this IndexActionType value) => value switch
        {
            IndexActionType.Upload => "upload",
            IndexActionType.Merge => "merge",
            IndexActionType.MergeOrUpload => "mergeOrUpload",
            IndexActionType.Delete => "delete",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IndexActionType value.")
        };

        public static IndexActionType ToIndexActionType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "upload")) return IndexActionType.Upload;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "merge")) return IndexActionType.Merge;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "mergeOrUpload")) return IndexActionType.MergeOrUpload;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "delete")) return IndexActionType.Delete;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IndexActionType value.");
        }
    }
}
