// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class QueueLabelSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("labelSelectors");
            writer.WriteStartArray();
            foreach (var item in LabelSelectors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static QueueLabelSelector DeserializeQueueLabelSelector(JsonElement element)
        {
            IList<LabelSelectorAttachment> labelSelectors = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labelSelectors"))
                {
                    List<LabelSelectorAttachment> array = new List<LabelSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LabelSelectorAttachment.DeserializeLabelSelectorAttachment(item));
                    }
                    labelSelectors = array;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new QueueLabelSelector(kind, labelSelectors);
        }
    }
}
