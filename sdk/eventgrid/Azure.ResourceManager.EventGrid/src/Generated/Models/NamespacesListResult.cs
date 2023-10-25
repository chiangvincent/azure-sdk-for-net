// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Namespaces operation. </summary>
    internal partial class NamespacesListResult
    {
        /// <summary> Initializes a new instance of NamespacesListResult. </summary>
        internal NamespacesListResult()
        {
            Value = new ChangeTrackingList<EventGridNamespaceData>();
        }

        /// <summary> Initializes a new instance of NamespacesListResult. </summary>
        /// <param name="value"> A collection of namespaces. </param>
        /// <param name="nextLink"> A link for the next page of namespaces. </param>
        internal NamespacesListResult(IReadOnlyList<EventGridNamespaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of namespaces. </summary>
        public IReadOnlyList<EventGridNamespaceData> Value { get; }
        /// <summary> A link for the next page of namespaces. </summary>
        public string NextLink { get; }
    }
}
