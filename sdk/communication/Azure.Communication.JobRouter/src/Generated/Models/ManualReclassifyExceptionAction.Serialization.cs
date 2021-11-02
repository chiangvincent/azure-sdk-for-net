// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class ManualReclassifyExceptionAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static ManualReclassifyExceptionAction DeserializeManualReclassifyExceptionAction(JsonElement element)
        {
            Optional<string> queueId = default;
            Optional<int?> priority = default;
            Optional<IList<LabelSelector>> workerSelectors = default;
            string kind = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        priority = null;
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerSelectors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workerSelectors = null;
                        continue;
                    }
                    List<LabelSelector> array = new List<LabelSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LabelSelector.DeserializeLabelSelector(item));
                    }
                    workerSelectors = array;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ManualReclassifyExceptionAction(kind, id, queueId.Value, Optional.ToNullable(priority), Optional.ToList(workerSelectors));
        }
    }
}
