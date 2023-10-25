// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobProviderError
    {
        internal static SiteRecoveryJobProviderError DeserializeSiteRecoveryJobProviderError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<string> errorId = default;
            Optional<string> possibleCauses = default;
            Optional<string> recommendedAction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorId"u8))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCauses"u8))
                {
                    possibleCauses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
            }
            return new SiteRecoveryJobProviderError(Optional.ToNullable(errorCode), errorMessage.Value, errorId.Value, possibleCauses.Value, recommendedAction.Value);
        }
    }
}
