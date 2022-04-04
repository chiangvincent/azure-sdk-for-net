// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    internal partial class TaskListResult
    {
        internal static TaskListResult DeserializeTaskListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Task>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Task> array = new List<Task>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Task.DeserializeTask(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TaskListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
