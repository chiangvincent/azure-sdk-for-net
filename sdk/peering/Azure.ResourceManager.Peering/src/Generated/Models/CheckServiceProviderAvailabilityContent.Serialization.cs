// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class CheckServiceProviderAvailabilityContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringServiceLocation))
            {
                writer.WritePropertyName("peeringServiceLocation");
                writer.WriteStringValue(PeeringServiceLocation);
            }
            if (Optional.IsDefined(PeeringServiceProvider))
            {
                writer.WritePropertyName("peeringServiceProvider");
                writer.WriteStringValue(PeeringServiceProvider);
            }
            writer.WriteEndObject();
        }
    }
}
