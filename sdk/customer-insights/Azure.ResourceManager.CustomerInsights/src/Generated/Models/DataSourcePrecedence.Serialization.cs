// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class DataSourcePrecedence
    {
        internal static DataSourcePrecedence DeserializeDataSourcePrecedence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> precedence = default;
            Optional<string> name = default;
            Optional<DataSourceType> dataSourceType = default;
            Optional<Status> status = default;
            Optional<int> id = default;
            Optional<string> dataSourceReferenceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("precedence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    precedence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"u8))
                        {
                            name = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataSourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSourceType = new DataSourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new Status(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dataSourceReferenceId"u8))
                        {
                            dataSourceReferenceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataSourcePrecedence(Optional.ToNullable(precedence), name.Value, Optional.ToNullable(dataSourceType), Optional.ToNullable(status), Optional.ToNullable(id), dataSourceReferenceId.Value);
        }
    }
}
