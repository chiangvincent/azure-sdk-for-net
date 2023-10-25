// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list pipeline runs. </summary>
    internal partial class DataFactoryPipelineRunsQueryResult
    {
        /// <summary> Initializes a new instance of DataFactoryPipelineRunsQueryResult. </summary>
        /// <param name="value"> List of pipeline runs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataFactoryPipelineRunsQueryResult(IEnumerable<DataFactoryPipelineRunInfo> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DataFactoryPipelineRunsQueryResult. </summary>
        /// <param name="value"> List of pipeline runs. </param>
        /// <param name="continuationToken"> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </param>
        internal DataFactoryPipelineRunsQueryResult(IReadOnlyList<DataFactoryPipelineRunInfo> value, string continuationToken)
        {
            Value = value;
            ContinuationToken = continuationToken;
        }

        /// <summary> List of pipeline runs. </summary>
        public IReadOnlyList<DataFactoryPipelineRunInfo> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string ContinuationToken { get; }
    }
}
