// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Identifies the type of validation request. </summary>
    internal enum ValidationInputDiscriminator
    {
        /// <summary> Identify request and response of address validation. </summary>
        ValidateAddress,
        /// <summary> Identify request and response for validation of subscription permission to create job. </summary>
        ValidateSubscriptionIsAllowedToCreateJob,
        /// <summary> Identify request and response of preference validation. </summary>
        ValidatePreferences,
        /// <summary> Identify request and response of create order limit for subscription validation. </summary>
        ValidateCreateOrderLimit,
        /// <summary> Identify request and response of active job limit for sku availability. </summary>
        ValidateSkuAvailability,
        /// <summary> Identify request and response of data transfer details validation. </summary>
        ValidateDataTransferDetails
    }
}
