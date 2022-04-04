// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    /// <summary> The disk encryption configuration applied on compute nodes in the pool. Disk encryption configuration is not supported on Linux pool created with Shared Image Gallery Image. </summary>
    public partial class DiskEncryptionConfiguration
    {
        /// <summary> Initializes a new instance of DiskEncryptionConfiguration. </summary>
        public DiskEncryptionConfiguration()
        {
            Targets = new ChangeTrackingList<DiskEncryptionTarget>();
        }

        /// <summary> Initializes a new instance of DiskEncryptionConfiguration. </summary>
        /// <param name="targets"> If omitted, no disks on the compute nodes in the pool will be encrypted. On Linux pool, only &quot;TemporaryDisk&quot; is supported; on Windows pool, &quot;OsDisk&quot; and &quot;TemporaryDisk&quot; must be specified. </param>
        internal DiskEncryptionConfiguration(IList<DiskEncryptionTarget> targets)
        {
            Targets = targets;
        }

        /// <summary> If omitted, no disks on the compute nodes in the pool will be encrypted. On Linux pool, only &quot;TemporaryDisk&quot; is supported; on Windows pool, &quot;OsDisk&quot; and &quot;TemporaryDisk&quot; must be specified. </summary>
        public IList<DiskEncryptionTarget> Targets { get; }
    }
}
