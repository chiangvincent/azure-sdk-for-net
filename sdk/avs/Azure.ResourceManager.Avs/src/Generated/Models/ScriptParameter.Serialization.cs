// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptParameter
    {
        internal static ScriptParameter DeserializeScriptParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScriptParameterType> type = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<ParameterVisibilityStatus> visibility = default;
            Optional<ParameterOptionalityStatus> optional = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ScriptParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visibility = new ParameterVisibilityStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optional = new ParameterOptionalityStatus(property.Value.GetString());
                    continue;
                }
            }
            return new ScriptParameter(Core.Optional.ToNullable(type), name.Value, description.Value, Core.Optional.ToNullable(visibility), Core.Optional.ToNullable(optional));
        }
    }
}
