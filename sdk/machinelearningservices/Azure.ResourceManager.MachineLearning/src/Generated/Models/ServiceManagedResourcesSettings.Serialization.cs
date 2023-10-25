// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ServiceManagedResourcesSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CosmosDb))
            {
                writer.WritePropertyName("cosmosDb"u8);
                writer.WriteObjectValue(CosmosDb);
            }
            writer.WriteEndObject();
        }

        internal static ServiceManagedResourcesSettings DeserializeServiceManagedResourcesSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CosmosDbSettings> cosmosDb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cosmosDb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cosmosDb = CosmosDbSettings.DeserializeCosmosDbSettings(property.Value);
                    continue;
                }
            }
            return new ServiceManagedResourcesSettings(cosmosDb.Value);
        }
    }
}
