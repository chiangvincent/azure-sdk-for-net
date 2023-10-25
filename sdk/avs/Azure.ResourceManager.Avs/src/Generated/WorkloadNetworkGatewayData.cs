// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the WorkloadNetworkGateway data model.
    /// NSX Gateway.
    /// </summary>
    public partial class WorkloadNetworkGatewayData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkloadNetworkGatewayData. </summary>
        public WorkloadNetworkGatewayData()
        {
        }

        /// <summary> Initializes a new instance of WorkloadNetworkGatewayData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the DHCP entity. </param>
        /// <param name="path"> NSX Gateway Path. </param>
        internal WorkloadNetworkGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string path) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Path = path;
        }

        /// <summary> Display name of the DHCP entity. </summary>
        public string DisplayName { get; set; }
        /// <summary> NSX Gateway Path. </summary>
        public string Path { get; }
    }
}
