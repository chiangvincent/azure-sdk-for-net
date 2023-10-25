// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteBuildData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StaticSiteBuildData DeserializeStaticSiteBuildData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> buildId = default;
            Optional<string> sourceBranch = default;
            Optional<string> pullRequestTitle = default;
            Optional<string> hostname = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<DateTimeOffset> lastUpdatedOn = default;
            Optional<StaticSiteBuildStatus> status = default;
            Optional<IReadOnlyList<StaticSiteUserProvidedFunctionAppData>> userProvidedFunctionApps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("buildId"u8))
                        {
                            buildId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceBranch"u8))
                        {
                            sourceBranch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pullRequestTitle"u8))
                        {
                            pullRequestTitle = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostname"u8))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new StaticSiteBuildStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userProvidedFunctionApps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StaticSiteUserProvidedFunctionAppData> array = new List<StaticSiteUserProvidedFunctionAppData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StaticSiteUserProvidedFunctionAppData.DeserializeStaticSiteUserProvidedFunctionAppData(item));
                            }
                            userProvidedFunctionApps = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StaticSiteBuildData(id, name, type, systemData.Value, buildId.Value, sourceBranch.Value, pullRequestTitle.Value, hostname.Value, Optional.ToNullable(createdTimeUtc), Optional.ToNullable(lastUpdatedOn), Optional.ToNullable(status), Optional.ToList(userProvidedFunctionApps), kind.Value);
        }
    }
}
