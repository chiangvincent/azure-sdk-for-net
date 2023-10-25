// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseWorkspaceAadAdminInfo data model.
    /// Workspace active directory administrator
    /// </summary>
    public partial class SynapseWorkspaceAadAdminInfoData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseWorkspaceAadAdminInfoData. </summary>
        public SynapseWorkspaceAadAdminInfoData()
        {
        }

        /// <summary> Initializes a new instance of SynapseWorkspaceAadAdminInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tenantId"> Tenant ID of the workspace active directory administrator. </param>
        /// <param name="login"> Login of the workspace active directory administrator. </param>
        /// <param name="administratorType"> Workspace active directory administrator type. </param>
        /// <param name="sid"> Object ID of the workspace active directory administrator. </param>
        internal SynapseWorkspaceAadAdminInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? tenantId, string login, string administratorType, string sid) : base(id, name, resourceType, systemData)
        {
            TenantId = tenantId;
            Login = login;
            AdministratorType = administratorType;
            Sid = sid;
        }

        /// <summary> Tenant ID of the workspace active directory administrator. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Login of the workspace active directory administrator. </summary>
        public string Login { get; set; }
        /// <summary> Workspace active directory administrator type. </summary>
        public string AdministratorType { get; set; }
        /// <summary> Object ID of the workspace active directory administrator. </summary>
        public string Sid { get; set; }
    }
}
