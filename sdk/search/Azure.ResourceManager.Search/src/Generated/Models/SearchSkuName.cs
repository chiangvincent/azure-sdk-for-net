// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The SKU of the search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). 'storage_optimized_l1': Supports 1TB per partition, up to 12 partitions. 'storage_optimized_l2': Supports 2TB per partition, up to 12 partitions.'. </summary>
    public enum SearchSkuName
    {
        /// <summary> Free tier, with no SLA guarantees and a subset of features offered to paid tiers. </summary>
        Free,
        /// <summary> Paid tier dedicated service with up to 3 replicas. </summary>
        Basic,
        /// <summary> Paid tier dedicated service with up to 12 partitions and 12 replicas. </summary>
        Standard,
        /// <summary> Similar to 'standard', but with more capacity per search unit. </summary>
        Standard2,
        /// <summary> The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). </summary>
        Standard3,
        /// <summary> Paid tier dedicated service that supports 1TB per partition, up to 12 partitions. </summary>
        StorageOptimizedL1,
        /// <summary> Paid tier dedicated service that supports 2TB per partition, up to 12 partitions. </summary>
        StorageOptimizedL2
    }
}
