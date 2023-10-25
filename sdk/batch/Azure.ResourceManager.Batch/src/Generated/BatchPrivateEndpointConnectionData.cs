// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchPrivateEndpointConnection data model.
    /// Contains information about a private link resource.
    /// </summary>
    public partial class BatchPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of BatchPrivateEndpointConnectionData. </summary>
        public BatchPrivateEndpointConnectionData()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of BatchPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection. </param>
        /// <param name="privateEndpoint"> The private endpoint of the private endpoint connection. </param>
        /// <param name="groupIds"> The value has one and only one group id. </param>
        /// <param name="connectionState"> The private link service connection state of the private endpoint connection. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        internal BatchPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BatchPrivateEndpointConnectionProvisioningState? provisioningState, SubResource privateEndpoint, IReadOnlyList<string> groupIds, BatchPrivateLinkServiceConnectionState connectionState, ETag? etag) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            ConnectionState = connectionState;
            ETag = etag;
        }

        /// <summary> The provisioning state of the private endpoint connection. </summary>
        public BatchPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> The private endpoint of the private endpoint connection. </summary>
        internal SubResource PrivateEndpoint { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> The value has one and only one group id. </summary>
        public IReadOnlyList<string> GroupIds { get; }
        /// <summary> The private link service connection state of the private endpoint connection. </summary>
        public BatchPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
