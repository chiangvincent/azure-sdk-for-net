// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    internal partial class CreateJobRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelReference))
            {
                writer.WritePropertyName("channelReference");
                writer.WriteStringValue(ChannelReference);
            }
            writer.WritePropertyName("channelId");
            writer.WriteStringValue(ChannelId);
            if (Optional.IsDefined(ClassificationPolicyId))
            {
                writer.WritePropertyName("classificationPolicyId");
                writer.WriteStringValue(ClassificationPolicyId);
            }
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId");
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority");
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsCollectionDefined(WorkerSelectors))
            {
                if (WorkerSelectors != null)
                {
                    writer.WritePropertyName("workerSelectors");
                    writer.WriteStartArray();
                    foreach (var item in WorkerSelectors)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("workerSelectors");
                }
            }
            if (Optional.IsCollectionDefined(_labels))
            {
                if (_labels != null)
                {
                    writer.WritePropertyName("labels");
                    writer.WriteStartObject();
                    foreach (var item in _labels)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("labels");
                }
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note");
                writer.WriteStringValue(Note);
            }
            writer.WriteEndObject();
        }
    }
}
