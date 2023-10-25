// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseManagedIdentitySqlControlSetting data model.
    /// Sql Control Settings for workspace managed identity
    /// </summary>
    public partial class SynapseManagedIdentitySqlControlSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseManagedIdentitySqlControlSettingData. </summary>
        public SynapseManagedIdentitySqlControlSettingData()
        {
        }

        /// <summary> Initializes a new instance of SynapseManagedIdentitySqlControlSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="grantSqlControlToManagedIdentity"> Grant sql control to managed identity. </param>
        internal SynapseManagedIdentitySqlControlSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SynapseGrantSqlControlToManagedIdentity grantSqlControlToManagedIdentity) : base(id, name, resourceType, systemData)
        {
            GrantSqlControlToManagedIdentity = grantSqlControlToManagedIdentity;
        }

        /// <summary> Grant sql control to managed identity. </summary>
        public SynapseGrantSqlControlToManagedIdentity GrantSqlControlToManagedIdentity { get; set; }
    }
}
