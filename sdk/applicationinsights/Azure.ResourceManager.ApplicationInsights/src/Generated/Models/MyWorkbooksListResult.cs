// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Workbook list result. </summary>
    internal partial class MyWorkbooksListResult
    {
        /// <summary> Initializes a new instance of MyWorkbooksListResult. </summary>
        internal MyWorkbooksListResult()
        {
            Value = new ChangeTrackingList<MyWorkbookData>();
        }

        /// <summary> Initializes a new instance of MyWorkbooksListResult. </summary>
        /// <param name="value"> An array of private workbooks. </param>
        /// <param name="nextLink"></param>
        internal MyWorkbooksListResult(IReadOnlyList<MyWorkbookData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of private workbooks. </summary>
        public IReadOnlyList<MyWorkbookData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
