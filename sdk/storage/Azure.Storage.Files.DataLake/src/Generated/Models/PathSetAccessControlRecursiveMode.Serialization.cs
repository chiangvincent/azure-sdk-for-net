// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    internal static partial class PathSetAccessControlRecursiveModeExtensions
    {
        public static string ToSerialString(this PathSetAccessControlRecursiveMode value) => value switch
        {
            PathSetAccessControlRecursiveMode.Set => "set",
            PathSetAccessControlRecursiveMode.Modify => "modify",
            PathSetAccessControlRecursiveMode.Remove => "remove",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathSetAccessControlRecursiveMode value.")
        };

        public static PathSetAccessControlRecursiveMode ToPathSetAccessControlRecursiveMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "set")) return PathSetAccessControlRecursiveMode.Set;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "modify")) return PathSetAccessControlRecursiveMode.Modify;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "remove")) return PathSetAccessControlRecursiveMode.Remove;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathSetAccessControlRecursiveMode value.");
        }
    }
}
