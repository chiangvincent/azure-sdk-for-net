// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MachineLearningServicesRunCompletedEventDataConverter))]
    public partial class MachineLearningServicesRunCompletedEventData
    {
        internal static MachineLearningServicesRunCompletedEventData DeserializeMachineLearningServicesRunCompletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> experimentId = default;
            Optional<string> experimentName = default;
            Optional<string> runId = default;
            Optional<string> runType = default;
            Optional<object> runTags = default;
            Optional<object> runProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("experimentId"u8))
                {
                    experimentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("experimentName"u8))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runType"u8))
                {
                    runType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runTags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("runProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new MachineLearningServicesRunCompletedEventData(experimentId.Value, experimentName.Value, runId.Value, runType.Value, runTags.Value, runProperties.Value);
        }

        internal partial class MachineLearningServicesRunCompletedEventDataConverter : JsonConverter<MachineLearningServicesRunCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesRunCompletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MachineLearningServicesRunCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesRunCompletedEventData(document.RootElement);
            }
        }
    }
}
