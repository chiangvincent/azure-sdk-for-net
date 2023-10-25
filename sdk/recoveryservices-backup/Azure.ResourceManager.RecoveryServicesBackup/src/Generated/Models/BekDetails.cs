// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> BEK is bitlocker encryption key. </summary>
    public partial class BekDetails
    {
        /// <summary> Initializes a new instance of BekDetails. </summary>
        public BekDetails()
        {
        }

        /// <summary> Initializes a new instance of BekDetails. </summary>
        /// <param name="secretUri"> Secret is BEK. </param>
        /// <param name="secretVaultId"> ID of the Key Vault where this Secret is stored. </param>
        /// <param name="secretData"> BEK data. </param>
        internal BekDetails(Uri secretUri, ResourceIdentifier secretVaultId, string secretData)
        {
            SecretUri = secretUri;
            SecretVaultId = secretVaultId;
            SecretData = secretData;
        }

        /// <summary> Secret is BEK. </summary>
        public Uri SecretUri { get; set; }
        /// <summary> ID of the Key Vault where this Secret is stored. </summary>
        public ResourceIdentifier SecretVaultId { get; set; }
        /// <summary> BEK data. </summary>
        public string SecretData { get; set; }
    }
}
