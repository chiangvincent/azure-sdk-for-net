// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> PAN Rulestack Describe Object. </summary>
    public partial class GlobalRulestackInfo
    {
        /// <summary> Initializes a new instance of GlobalRulestackInfo. </summary>
        /// <param name="azureId"> rulestack description. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureId"/> is null. </exception>
        internal GlobalRulestackInfo(string azureId)
        {
            Argument.AssertNotNull(azureId, nameof(azureId));

            AzureId = azureId;
        }

        /// <summary> rulestack description. </summary>
        public string AzureId { get; }
    }
}
