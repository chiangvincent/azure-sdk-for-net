// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class PathList
    {
        internal static PathList DeserializePathList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<Path>> paths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("paths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Path> array = new List<Path>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Path.DeserializePath(item));
                    }
                    paths = array;
                    continue;
                }
            }
            return new PathList(Optional.ToList(paths));
        }
    }
}
