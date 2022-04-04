// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class TaskExecutionInformation
    {
        internal static TaskExecutionInformation DeserializeTaskExecutionInformation(JsonElement element)
        {
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<int> exitCode = default;
            Optional<TaskContainerExecutionInformation> containerInfo = default;
            Optional<TaskFailureInformation> failureInfo = default;
            int retryCount = default;
            Optional<DateTimeOffset> lastRetryTime = default;
            int requeueCount = default;
            Optional<DateTimeOffset> lastRequeueTime = default;
            Optional<TaskExecutionResult> result = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("exitCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exitCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerInfo = TaskContainerExecutionInformation.DeserializeTaskContainerExecutionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("failureInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failureInfo = TaskFailureInformation.DeserializeTaskFailureInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("retryCount"))
                {
                    retryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastRetryTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastRetryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("requeueCount"))
                {
                    requeueCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastRequeueTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastRequeueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    result = property.Value.GetString().ToTaskExecutionResult();
                    continue;
                }
            }
            return new TaskExecutionInformation(Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(exitCode), containerInfo.Value, failureInfo.Value, retryCount, Optional.ToNullable(lastRetryTime), requeueCount, Optional.ToNullable(lastRequeueTime), Optional.ToNullable(result));
        }
    }
}
