// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Query user's offers properties. </summary>
    public partial class QueryUserOffersContent
    {
        /// <summary> Initializes a new instance of QueryUserOffersContent. </summary>
        public QueryUserOffersContent()
        {
            OfferIds = new ChangeTrackingList<string>();
            SubscriptionIds = new ChangeTrackingList<string>();
        }

        /// <summary> List of offer IDs. </summary>
        public IList<string> OfferIds { get; }
        /// <summary> List of subscription IDs. </summary>
        public IList<string> SubscriptionIds { get; }
    }
}
