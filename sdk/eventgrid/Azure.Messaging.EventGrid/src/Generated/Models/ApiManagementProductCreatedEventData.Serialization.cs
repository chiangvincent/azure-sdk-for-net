// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementProductCreatedEventDataConverter))]
    public partial class ApiManagementProductCreatedEventData
    {
        internal static ApiManagementProductCreatedEventData DeserializeApiManagementProductCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementProductCreatedEventData(resourceUri.Value);
        }

        internal partial class ApiManagementProductCreatedEventDataConverter : JsonConverter<ApiManagementProductCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementProductCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementProductCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementProductCreatedEventData(document.RootElement);
            }
        }
    }
}
