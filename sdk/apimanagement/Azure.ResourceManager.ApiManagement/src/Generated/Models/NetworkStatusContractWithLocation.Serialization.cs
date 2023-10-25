// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class NetworkStatusContractWithLocation
    {
        internal static NetworkStatusContractWithLocation DeserializeNetworkStatusContractWithLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<NetworkStatusContract> networkStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkStatus = NetworkStatusContract.DeserializeNetworkStatusContract(property.Value);
                    continue;
                }
            }
            return new NetworkStatusContractWithLocation(Optional.ToNullable(location), networkStatus.Value);
        }
    }
}
