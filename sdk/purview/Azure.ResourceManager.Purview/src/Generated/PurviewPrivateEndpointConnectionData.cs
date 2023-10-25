// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Purview.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Purview
{
    /// <summary>
    /// A class representing the PurviewPrivateEndpointConnection data model.
    /// A private endpoint connection class.
    /// </summary>
    public partial class PurviewPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of PurviewPrivateEndpointConnectionData. </summary>
        public PurviewPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PurviewPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The private endpoint information. </param>
        /// <param name="connectionState"> The private link service connection state. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        internal PurviewPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WritableSubResource privateEndpoint, PurviewPrivateLinkServiceConnectionState connectionState, string provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The private endpoint information. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> The private link service connection state. </summary>
        public PurviewPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
