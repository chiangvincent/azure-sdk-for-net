// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RoutingRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FrontendEndpoints))
            {
                writer.WritePropertyName("frontendEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendEndpoints)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AcceptedProtocols))
            {
                writer.WritePropertyName("acceptedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in AcceptedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(RouteConfiguration))
            {
                writer.WritePropertyName("routeConfiguration"u8);
                writer.WriteObjectValue(RouteConfiguration);
            }
            if (Optional.IsDefined(RulesEngine))
            {
                writer.WritePropertyName("rulesEngine"u8);
                JsonSerializer.Serialize(writer, RulesEngine);
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                JsonSerializer.Serialize(writer, WebApplicationFirewallPolicyLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoutingRuleData DeserializeRoutingRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<IList<WritableSubResource>> frontendEndpoints = default;
            Optional<IList<FrontDoorProtocol>> acceptedProtocols = default;
            Optional<IList<string>> patternsToMatch = default;
            Optional<RoutingRuleEnabledState> enabledState = default;
            Optional<RouteConfiguration> routeConfiguration = default;
            Optional<WritableSubResource> rulesEngine = default;
            Optional<WritableSubResource> webApplicationFirewallPolicyLink = default;
            Optional<FrontDoorResourceState> resourceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("frontendEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            frontendEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("acceptedProtocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorProtocol> array = new List<FrontDoorProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new FrontDoorProtocol(item.GetString()));
                            }
                            acceptedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new RoutingRuleEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routeConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeConfiguration = RouteConfiguration.DeserializeRouteConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rulesEngine"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rulesEngine = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            webApplicationFirewallPolicyLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoutingRuleData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToList(frontendEndpoints), Optional.ToList(acceptedProtocols), Optional.ToList(patternsToMatch), Optional.ToNullable(enabledState), routeConfiguration.Value, rulesEngine, webApplicationFirewallPolicyLink, Optional.ToNullable(resourceState));
        }
    }
}
