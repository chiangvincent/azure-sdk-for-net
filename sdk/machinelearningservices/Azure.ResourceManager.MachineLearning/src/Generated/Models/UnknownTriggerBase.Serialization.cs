// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownTriggerBase : IUtf8JsonSerializable, IJsonModel<MachineLearningTriggerBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningTriggerBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningTriggerBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTriggerBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTriggerBase)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("triggerType"u8);
            writer.WriteStringValue(TriggerType.ToString());
            if (Optional.IsDefined(EndTime))
            {
                if (EndTime != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndTime);
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Optional.IsDefined(StartTime))
            {
                if (StartTime != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartTime);
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningTriggerBase IJsonModel<MachineLearningTriggerBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTriggerBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTriggerBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningTriggerBase(document.RootElement, options);
        }

        internal static UnknownTriggerBase DeserializeUnknownTriggerBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerType triggerType = "Unknown";
            string endTime = default;
            string startTime = default;
            string timeZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = new TriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownTriggerBase(triggerType, endTime, startTime, timeZone, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TriggerType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  triggerType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  triggerType: ");
                builder.AppendLine($"'{TriggerType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndTime))
                {
                    builder.Append("  endTime: ");
                    if (EndTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartTime))
                {
                    builder.Append("  startTime: ");
                    if (StartTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeZone))
                {
                    builder.Append("  timeZone: ");
                    if (TimeZone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TimeZone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TimeZone}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningTriggerBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTriggerBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTriggerBase)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningTriggerBase IPersistableModel<MachineLearningTriggerBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTriggerBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningTriggerBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTriggerBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningTriggerBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
