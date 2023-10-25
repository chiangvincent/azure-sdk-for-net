// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    /// <summary> The request of removing blockItems from text blocklist. </summary>
    public partial class RemoveBlockItemsOptions
    {
        /// <summary> Initializes a new instance of RemoveBlockItemsOptions. </summary>
        /// <param name="blockItemIds"> Array of blockItemIds to remove. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blockItemIds"/> is null. </exception>
        public RemoveBlockItemsOptions(IEnumerable<string> blockItemIds)
        {
            Argument.AssertNotNull(blockItemIds, nameof(blockItemIds));

            BlockItemIds = blockItemIds.ToList();
        }

        /// <summary> Initializes a new instance of RemoveBlockItemsOptions. </summary>
        /// <param name="blockItemIds"> Array of blockItemIds to remove. </param>
        internal RemoveBlockItemsOptions(IList<string> blockItemIds)
        {
            BlockItemIds = blockItemIds;
        }

        /// <summary> Array of blockItemIds to remove. </summary>
        public IList<string> BlockItemIds { get; }
    }
}
