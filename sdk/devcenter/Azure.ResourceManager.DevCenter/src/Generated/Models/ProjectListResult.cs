// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Results of the project list operation. </summary>
    internal partial class ProjectListResult
    {
        /// <summary> Initializes a new instance of ProjectListResult. </summary>
        internal ProjectListResult()
        {
            Value = new ChangeTrackingList<DevCenterProjectData>();
        }

        /// <summary> Initializes a new instance of ProjectListResult. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        internal ProjectListResult(IReadOnlyList<DevCenterProjectData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<DevCenterProjectData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
