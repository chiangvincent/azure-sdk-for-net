// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class NodeVMExtension
    {
        internal static NodeVMExtension DeserializeNodeVMExtension(JsonElement element)
        {
            Optional<string> provisioningState = default;
            Optional<VMExtension> vmExtension = default;
            Optional<VMExtensionInstanceView> instanceView = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmExtension"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vmExtension = VMExtension.DeserializeVMExtension(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceView"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instanceView = VMExtensionInstanceView.DeserializeVMExtensionInstanceView(property.Value);
                    continue;
                }
            }
            return new NodeVMExtension(provisioningState.Value, vmExtension.Value, instanceView.Value);
        }
    }
}
