// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Trigger for an exception action on exceeding wait time. </summary>
    public partial class WaitTimeExceptionTrigger : JobExceptionTrigger
    {

        /// <summary> Initializes a new instance of WaitTimeExceptionTrigger. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionTrigger. </param>
        /// <param name="threshold"> Threshold for wait time for this trigger. </param>
        internal WaitTimeExceptionTrigger(string kind, TimeSpan threshold) : base(kind)
        {
            Threshold = threshold;
            Kind = kind ?? "wait-time";
        }
    }
}
