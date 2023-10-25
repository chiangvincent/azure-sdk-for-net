// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class AzureDevOpsOrgMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AutoDiscovery))
            {
                writer.WritePropertyName("autoDiscovery"u8);
                writer.WriteStringValue(AutoDiscovery.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Projects))
            {
                writer.WritePropertyName("projects"u8);
                writer.WriteStartArray();
                foreach (var item in Projects)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AzureDevOpsOrgMetadata DeserializeAzureDevOpsOrgMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AutoDiscovery> autoDiscovery = default;
            Optional<IList<AzureDevOpsProjectMetadata>> projects = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoDiscovery = new AutoDiscovery(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("projects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureDevOpsProjectMetadata> array = new List<AzureDevOpsProjectMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureDevOpsProjectMetadata.DeserializeAzureDevOpsProjectMetadata(item));
                    }
                    projects = array;
                    continue;
                }
            }
            return new AzureDevOpsOrgMetadata(name.Value, Optional.ToNullable(autoDiscovery), Optional.ToList(projects));
        }
    }
}
