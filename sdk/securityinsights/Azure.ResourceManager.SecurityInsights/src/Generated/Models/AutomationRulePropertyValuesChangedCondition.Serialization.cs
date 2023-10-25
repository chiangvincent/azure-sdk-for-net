// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRulePropertyValuesChangedCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PropertyName))
            {
                writer.WritePropertyName("propertyName"u8);
                writer.WriteStringValue(PropertyName.Value.ToString());
            }
            if (Optional.IsDefined(ChangeType))
            {
                writer.WritePropertyName("changeType"u8);
                writer.WriteStringValue(ChangeType.Value.ToString());
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PropertyValues))
            {
                writer.WritePropertyName("propertyValues"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AutomationRulePropertyValuesChangedCondition DeserializeAutomationRulePropertyValuesChangedCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRulePropertyChangedConditionSupportedPropertyType> propertyName = default;
            Optional<AutomationRulePropertyChangedConditionSupportedChangedType> changeType = default;
            Optional<AutomationRulePropertyConditionSupportedOperator> @operator = default;
            Optional<IList<string>> propertyValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyName = new AutomationRulePropertyChangedConditionSupportedPropertyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeType = new AutomationRulePropertyChangedConditionSupportedChangedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = new AutomationRulePropertyConditionSupportedOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    propertyValues = array;
                    continue;
                }
            }
            return new AutomationRulePropertyValuesChangedCondition(Optional.ToNullable(propertyName), Optional.ToNullable(changeType), Optional.ToNullable(@operator), Optional.ToList(propertyValues));
        }
    }
}
