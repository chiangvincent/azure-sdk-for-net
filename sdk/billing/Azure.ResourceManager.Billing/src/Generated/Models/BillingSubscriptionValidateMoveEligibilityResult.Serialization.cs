// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingSubscriptionValidateMoveEligibilityResult
    {
        internal static BillingSubscriptionValidateMoveEligibilityResult DeserializeBillingSubscriptionValidateMoveEligibilityResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isMoveEligible = default;
            Optional<BillingSubscriptionValidateMoveEligibilityError> errorDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isMoveEligible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMoveEligible = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetails = BillingSubscriptionValidateMoveEligibilityError.DeserializeBillingSubscriptionValidateMoveEligibilityError(property.Value);
                    continue;
                }
            }
            return new BillingSubscriptionValidateMoveEligibilityResult(Optional.ToNullable(isMoveEligible), errorDetails.Value);
        }
    }
}
