// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Response payload for creating or updating a classification policy. </summary>
    public partial class UpsertClassificationPolicyResponse
    {
        /// <summary> Initializes a new instance of UpsertClassificationPolicyResponse. </summary>
        /// <param name="id"> Unique identifier of this policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal UpsertClassificationPolicyResponse(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            WorkerSelectors = new ChangeTrackingList<LabelSelectorAttachment>();
        }

        /// <summary> Initializes a new instance of UpsertClassificationPolicyResponse. </summary>
        /// <param name="id"> Unique identifier of this policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="fallbackQueueId"> The fallback queue to select if the queue selector doesn&apos;t find a match. </param>
        /// <param name="queueSelector"> The queue selector to select a queue for a given job. </param>
        /// <param name="prioritizationRule"> The rule to determine a priority score for a given job. </param>
        /// <param name="workerSelectors"> The worker label selectors to attach to a given job. </param>
        internal UpsertClassificationPolicyResponse(string id, string name, string fallbackQueueId, QueueSelector queueSelector, RouterRule prioritizationRule, IReadOnlyList<LabelSelectorAttachment> workerSelectors)
        {
            Id = id;
            Name = name;
            FallbackQueueId = fallbackQueueId;
            QueueSelector = queueSelector;
            PrioritizationRule = prioritizationRule;
            WorkerSelectors = workerSelectors;
        }

        /// <summary> Unique identifier of this policy. </summary>
        public string Id { get; }
        /// <summary> Friendly name of this policy. </summary>
        public string Name { get; }
        /// <summary> The fallback queue to select if the queue selector doesn&apos;t find a match. </summary>
        public string FallbackQueueId { get; }
        /// <summary> The queue selector to select a queue for a given job. </summary>
        public QueueSelector QueueSelector { get; }
        /// <summary> The rule to determine a priority score for a given job. </summary>
        public RouterRule PrioritizationRule { get; }
        /// <summary> The worker label selectors to attach to a given job. </summary>
        public IReadOnlyList<LabelSelectorAttachment> WorkerSelectors { get; }
    }
}
