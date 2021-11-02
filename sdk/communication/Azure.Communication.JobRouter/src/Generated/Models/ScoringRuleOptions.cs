// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Encapsulates all options that can be passed as parameters for scoring rule with BestWorkerMode. </summary>
    public partial class ScoringRuleOptions
    {
        /// <summary> Initializes a new instance of ScoringRuleOptions. </summary>
        public ScoringRuleOptions()
        {
            ScoringParameters = new ChangeTrackingList<ScoringRuleParameterSelector>();
        }

        /// <summary> Initializes a new instance of ScoringRuleOptions. </summary>
        /// <param name="batchSize"> (Optional) Set batch size when AllowScoringBatchOfWorkers is set to true. </param>
        /// <param name="scoringParameters">
        /// (Optional) List of parameters that will be sent as part of the payload to scoring rule.
        /// 
        /// If not provided, job labels, label selectors and worker labels are sent as part of the payload.
        /// </param>
        /// <param name="allowScoringBatchOfWorkers">
        /// (Optional)
        /// 
        /// If true, will try to obtain scores for a batch of workers.
        /// 
        /// By default, set to false. Use BatchSize to set batch size.
        /// </param>
        /// <param name="descendingOrder">
        /// (Optional)
        /// 
        /// If false, will sort scores by ascending order. By default, set to true.
        /// </param>
        internal ScoringRuleOptions(int? batchSize, IList<ScoringRuleParameterSelector> scoringParameters, bool? allowScoringBatchOfWorkers, bool? descendingOrder)
        {
            BatchSize = batchSize;
            ScoringParameters = scoringParameters;
            AllowScoringBatchOfWorkers = allowScoringBatchOfWorkers;
            DescendingOrder = descendingOrder;
        }

        /// <summary> (Optional) Set batch size when AllowScoringBatchOfWorkers is set to true. </summary>
        public int? BatchSize { get; set; }
        /// <summary>
        /// (Optional) List of parameters that will be sent as part of the payload to scoring rule.
        /// 
        /// If not provided, job labels, label selectors and worker labels are sent as part of the payload.
        /// </summary>
        public IList<ScoringRuleParameterSelector> ScoringParameters { get; set; }
        /// <summary>
        /// (Optional)
        /// 
        /// If true, will try to obtain scores for a batch of workers.
        /// 
        /// By default, set to false. Use BatchSize to set batch size.
        /// </summary>
        public bool? AllowScoringBatchOfWorkers { get; set; }
        /// <summary>
        /// (Optional)
        /// 
        /// If false, will sort scores by ascending order. By default, set to true.
        /// </summary>
        public bool? DescendingOrder { get; set; }
    }
}
