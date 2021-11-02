// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class DistributionMode : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("minConcurrentOffers");
            writer.WriteNumberValue(MinConcurrentOffers);
            writer.WritePropertyName("maxConcurrentOffers");
            writer.WriteNumberValue(MaxConcurrentOffers);
            if (Optional.IsDefined(BypassSelectors))
            {
                if (BypassSelectors != null)
                {
                    writer.WritePropertyName("bypassSelectors");
                    writer.WriteBooleanValue(BypassSelectors.Value);
                }
                else
                {
                    writer.WriteNull("bypassSelectors");
                }
            }
            writer.WriteEndObject();
        }

        internal static DistributionMode DeserializeDistributionMode(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "best-worker": return BestWorkerMode.DeserializeBestWorkerMode(element);
                    case "longest-idle": return LongestIdleMode.DeserializeLongestIdleMode(element);
                    case "round-robin": return RoundRobinMode.DeserializeRoundRobinMode(element);
                }
            }
            throw new NotSupportedException("Deserialization of abstract type 'global::Azure.Communication.JobRouter.Models.DistributionMode' not supported.");
        }
    }
}
