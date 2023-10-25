// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CustomActivityReferenceObjectConverter))]
    public partial class CustomActivityReferenceObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LinkedServices))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CustomActivityReferenceObject DeserializeCustomActivityReferenceObject(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<LinkedServiceReference>> linkedServices = default;
            Optional<IList<DatasetReference>> datasets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetReference.DeserializeDatasetReference(item));
                    }
                    datasets = array;
                    continue;
                }
            }
            return new CustomActivityReferenceObject(Optional.ToList(linkedServices), Optional.ToList(datasets));
        }

        internal partial class CustomActivityReferenceObjectConverter : JsonConverter<CustomActivityReferenceObject>
        {
            public override void Write(Utf8JsonWriter writer, CustomActivityReferenceObject model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CustomActivityReferenceObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCustomActivityReferenceObject(document.RootElement);
            }
        }
    }
}
