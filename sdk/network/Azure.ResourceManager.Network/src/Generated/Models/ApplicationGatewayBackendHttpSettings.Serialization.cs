// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendHttpSettings : IUtf8JsonSerializable
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
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(CookieBasedAffinity))
            {
                writer.WritePropertyName("cookieBasedAffinity"u8);
                writer.WriteStringValue(CookieBasedAffinity.Value.ToString());
            }
            if (Optional.IsDefined(RequestTimeoutInSeconds))
            {
                writer.WritePropertyName("requestTimeout"u8);
                writer.WriteNumberValue(RequestTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(Probe))
            {
                writer.WritePropertyName("probe"u8);
                JsonSerializer.Serialize(writer, Probe);
            }
            if (Optional.IsCollectionDefined(AuthenticationCertificates))
            {
                writer.WritePropertyName("authenticationCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in AuthenticationCertificates)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrustedRootCertificates))
            {
                writer.WritePropertyName("trustedRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedRootCertificates)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConnectionDraining))
            {
                writer.WritePropertyName("connectionDraining"u8);
                writer.WriteObjectValue(ConnectionDraining);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(PickHostNameFromBackendAddress))
            {
                writer.WritePropertyName("pickHostNameFromBackendAddress"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendAddress.Value);
            }
            if (Optional.IsDefined(AffinityCookieName))
            {
                writer.WritePropertyName("affinityCookieName"u8);
                writer.WriteStringValue(AffinityCookieName);
            }
            if (Optional.IsDefined(ProbeEnabled))
            {
                writer.WritePropertyName("probeEnabled"u8);
                writer.WriteBooleanValue(ProbeEnabled.Value);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayBackendHttpSettings DeserializeApplicationGatewayBackendHttpSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<int> port = default;
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<ApplicationGatewayCookieBasedAffinity> cookieBasedAffinity = default;
            Optional<int> requestTimeout = default;
            Optional<WritableSubResource> probe = default;
            Optional<IList<WritableSubResource>> authenticationCertificates = default;
            Optional<IList<WritableSubResource>> trustedRootCertificates = default;
            Optional<ApplicationGatewayConnectionDraining> connectionDraining = default;
            Optional<string> hostName = default;
            Optional<bool> pickHostNameFromBackendAddress = default;
            Optional<string> affinityCookieName = default;
            Optional<bool> probeEnabled = default;
            Optional<string> path = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cookieBasedAffinity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cookieBasedAffinity = new ApplicationGatewayCookieBasedAffinity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestTimeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestTimeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("probe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probe = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authenticationCertificates"u8))
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
                            authenticationCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("trustedRootCertificates"u8))
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
                            trustedRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("connectionDraining"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionDraining = ApplicationGatewayConnectionDraining.DeserializeApplicationGatewayConnectionDraining(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pickHostNameFromBackendAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("affinityCookieName"u8))
                        {
                            affinityCookieName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("probeEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayBackendHttpSettings(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(port), Optional.ToNullable(protocol), Optional.ToNullable(cookieBasedAffinity), Optional.ToNullable(requestTimeout), probe, Optional.ToList(authenticationCertificates), Optional.ToList(trustedRootCertificates), connectionDraining.Value, hostName.Value, Optional.ToNullable(pickHostNameFromBackendAddress), affinityCookieName.Value, Optional.ToNullable(probeEnabled), path.Value, Optional.ToNullable(provisioningState));
        }
    }
}
