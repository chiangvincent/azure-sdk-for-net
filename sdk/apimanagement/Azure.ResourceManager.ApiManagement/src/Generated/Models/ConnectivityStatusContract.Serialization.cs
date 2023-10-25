// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityStatusContract
    {
        internal static ConnectivityStatusContract DeserializeConnectivityStatusContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ConnectivityStatusType status = default;
            Optional<string> error = default;
            DateTimeOffset lastUpdated = default;
            DateTimeOffset lastStatusChange = default;
            string resourceType = default;
            bool isOptional = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new ConnectivityStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStatusChange"u8))
                {
                    lastStatusChange = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOptional"u8))
                {
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ConnectivityStatusContract(name, status, error.Value, lastUpdated, lastStatusChange, resourceType, isOptional);
        }
    }
}
