// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceCertificate data model.
    /// Key Vault container ARM resource for a certificate that is purchased through Azure.
    /// </summary>
    public partial class AppServiceCertificateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AppServiceCertificateData. </summary>
        /// <param name="location"> The location. </param>
        public AppServiceCertificateData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AppServiceCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="keyVaultId"> Key Vault resource Id. </param>
        /// <param name="keyVaultSecretName"> Key Vault secret name. </param>
        /// <param name="provisioningState"> Status of the Key Vault secret. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? provisioningState, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> Key Vault resource Id. </summary>
        public ResourceIdentifier KeyVaultId { get; set; }
        /// <summary> Key Vault secret name. </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary> Status of the Key Vault secret. </summary>
        public KeyVaultSecretStatus? ProvisioningState { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
