// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class PassThroughQueueSelectorAttachment
    {
        internal static PassThroughQueueSelectorAttachment DeserializePassThroughQueueSelectorAttachment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            LabelOperator labelOperator = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    labelOperator = new LabelOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new PassThroughQueueSelectorAttachment(kind, key, labelOperator);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new PassThroughQueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePassThroughQueueSelectorAttachment(document.RootElement);
        }
    }
}
