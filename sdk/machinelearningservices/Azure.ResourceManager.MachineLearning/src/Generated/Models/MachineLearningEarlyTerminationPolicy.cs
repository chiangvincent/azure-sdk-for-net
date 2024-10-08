// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Early termination policies enable canceling poor-performing runs before they complete
    /// Please note <see cref="MachineLearningEarlyTerminationPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BanditPolicy"/>, <see cref="MedianStoppingPolicy"/> and <see cref="TruncationSelectionPolicy"/>.
    /// </summary>
    public abstract partial class MachineLearningEarlyTerminationPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningEarlyTerminationPolicy"/>. </summary>
        protected MachineLearningEarlyTerminationPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEarlyTerminationPolicy"/>. </summary>
        /// <param name="policyType"> [Required] Name of policy configuration. </param>
        /// <param name="evaluationInterval"> Interval (number of runs) between policy evaluations. </param>
        /// <param name="delayEvaluation"> Number of intervals by which to delay the first evaluation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningEarlyTerminationPolicy(EarlyTerminationPolicyType policyType, int? evaluationInterval, int? delayEvaluation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyType = policyType;
            EvaluationInterval = evaluationInterval;
            DelayEvaluation = delayEvaluation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> [Required] Name of policy configuration. </summary>
        internal EarlyTerminationPolicyType PolicyType { get; set; }
        /// <summary> Interval (number of runs) between policy evaluations. </summary>
        [WirePath("evaluationInterval")]
        public int? EvaluationInterval { get; set; }
        /// <summary> Number of intervals by which to delay the first evaluation. </summary>
        [WirePath("delayEvaluation")]
        public int? DelayEvaluation { get; set; }
    }
}
