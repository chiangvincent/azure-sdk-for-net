// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    /// <summary> The vm extension instance view. </summary>
    public partial class VMExtensionInstanceView
    {
        /// <summary> Initializes a new instance of VMExtensionInstanceView. </summary>
        internal VMExtensionInstanceView()
        {
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
            SubStatuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of VMExtensionInstanceView. </summary>
        /// <param name="name"> The name of the vm extension instance view. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="subStatuses"> The resource status information. </param>
        internal VMExtensionInstanceView(string name, IReadOnlyList<InstanceViewStatus> statuses, IReadOnlyList<InstanceViewStatus> subStatuses)
        {
            Name = name;
            Statuses = statuses;
            SubStatuses = subStatuses;
        }

        /// <summary> The name of the vm extension instance view. </summary>
        public string Name { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> SubStatuses { get; }
    }
}
