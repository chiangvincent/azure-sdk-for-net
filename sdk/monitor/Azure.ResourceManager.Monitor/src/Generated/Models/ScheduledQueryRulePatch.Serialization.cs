// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ScheduledQueryRulePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteNumberValue(Severity.Value.ToSerialInt64());
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                writer.WritePropertyName("evaluationFrequency"u8);
                writer.WriteStringValue(EvaluationFrequency.Value, "P");
            }
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize"u8);
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            if (Optional.IsDefined(OverrideQueryTimeRange))
            {
                writer.WritePropertyName("overrideQueryTimeRange"u8);
                writer.WriteStringValue(OverrideQueryTimeRange.Value, "P");
            }
            if (Optional.IsCollectionDefined(TargetResourceTypes))
            {
                writer.WritePropertyName("targetResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in TargetResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Criteria))
            {
                writer.WritePropertyName("criteria"u8);
                writer.WriteObjectValue(Criteria);
            }
            if (Optional.IsDefined(MuteActionsDuration))
            {
                writer.WritePropertyName("muteActionsDuration"u8);
                writer.WriteStringValue(MuteActionsDuration.Value, "P");
            }
            if (Optional.IsDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteObjectValue(Actions);
            }
            if (Optional.IsDefined(CheckWorkspaceAlertsStorageConfigured))
            {
                writer.WritePropertyName("checkWorkspaceAlertsStorageConfigured"u8);
                writer.WriteBooleanValue(CheckWorkspaceAlertsStorageConfigured.Value);
            }
            if (Optional.IsDefined(SkipQueryValidation))
            {
                writer.WritePropertyName("skipQueryValidation"u8);
                writer.WriteBooleanValue(SkipQueryValidation.Value);
            }
            if (Optional.IsDefined(AutoMitigate))
            {
                writer.WritePropertyName("autoMitigate"u8);
                writer.WriteBooleanValue(AutoMitigate.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
