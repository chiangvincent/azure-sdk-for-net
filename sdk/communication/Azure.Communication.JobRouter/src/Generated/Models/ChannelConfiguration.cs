// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> The ChannelConfiguration. </summary>
    public partial class ChannelConfiguration
    {

        /// <summary> Unique key of the Channel. </summary>
        public string ChannelId { get; set; }
        /// <summary> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </summary>
        public int CapacityCostPerJob { get; set; }
    }
}
