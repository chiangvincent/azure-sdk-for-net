// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class CognitiveServicesVisionProcessor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint"u8);
            writer.WriteObjectValue(Endpoint);
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteObjectValue(Image);
            }
            if (Optional.IsDefined(SamplingOptions))
            {
                writer.WritePropertyName("samplingOptions"u8);
                writer.WriteObjectValue(SamplingOptions);
            }
            writer.WritePropertyName("operation"u8);
            writer.WriteObjectValue(Operation);
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static CognitiveServicesVisionProcessor DeserializeCognitiveServicesVisionProcessor(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointBase endpoint = default;
            Optional<ImageProperties> image = default;
            Optional<SamplingOptions> samplingOptions = default;
            SpatialAnalysisOperationBase operation = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = EndpointBase.DeserializeEndpointBase(property.Value);
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    image = ImageProperties.DeserializeImageProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingOptions = SamplingOptions.DeserializeSamplingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = SpatialAnalysisOperationBase.DeserializeSpatialAnalysisOperationBase(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new CognitiveServicesVisionProcessor(type, name, inputs, endpoint, image.Value, samplingOptions.Value, operation);
        }
    }
}
