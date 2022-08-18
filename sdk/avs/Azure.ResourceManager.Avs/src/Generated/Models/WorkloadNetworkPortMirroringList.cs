// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of NSX Port Mirroring. </summary>
    internal partial class WorkloadNetworkPortMirroringList
    {
        /// <summary> Initializes a new instance of WorkloadNetworkPortMirroringList. </summary>
        internal WorkloadNetworkPortMirroringList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkPortMirroringData>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkPortMirroringList. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal WorkloadNetworkPortMirroringList(IReadOnlyList<WorkloadNetworkPortMirroringData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkPortMirroringData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
