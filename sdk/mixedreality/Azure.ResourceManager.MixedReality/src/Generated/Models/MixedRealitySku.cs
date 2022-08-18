// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary>
    /// The resource model definition representing SKU
    /// Serialized Name: Sku
    /// </summary>
    public partial class MixedRealitySku
    {
        /// <summary> Initializes a new instance of MixedRealitySku. </summary>
        /// <param name="name">
        /// The name of the SKU. Ex - P3. It is typically a letter+number code
        /// Serialized Name: Sku.name
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MixedRealitySku(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of MixedRealitySku. </summary>
        /// <param name="name">
        /// The name of the SKU. Ex - P3. It is typically a letter+number code
        /// Serialized Name: Sku.name
        /// </param>
        /// <param name="tier">
        /// This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
        /// Serialized Name: Sku.tier
        /// </param>
        /// <param name="size">
        /// The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. 
        /// Serialized Name: Sku.size
        /// </param>
        /// <param name="family">
        /// If the service has different generations of hardware, for the same SKU, then that can be captured here.
        /// Serialized Name: Sku.family
        /// </param>
        /// <param name="capacity">
        /// If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted.
        /// Serialized Name: Sku.capacity
        /// </param>
        internal MixedRealitySku(string name, MixedRealitySkuTier? tier, string size, string family, int? capacity)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
        }

        /// <summary>
        /// The name of the SKU. Ex - P3. It is typically a letter+number code
        /// Serialized Name: Sku.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
        /// Serialized Name: Sku.tier
        /// </summary>
        public MixedRealitySkuTier? Tier { get; set; }
        /// <summary>
        /// The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. 
        /// Serialized Name: Sku.size
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// If the service has different generations of hardware, for the same SKU, then that can be captured here.
        /// Serialized Name: Sku.family
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted.
        /// Serialized Name: Sku.capacity
        /// </summary>
        public int? Capacity { get; set; }
    }
}
