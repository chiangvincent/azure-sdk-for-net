// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownSchedulePolicy. </summary>
    internal partial class UnknownSchedulePolicy : BackupSchedulePolicy
    {
        /// <summary> Initializes a new instance of UnknownSchedulePolicy. </summary>
        /// <param name="schedulePolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal UnknownSchedulePolicy(string schedulePolicyType) : base(schedulePolicyType)
        {
            SchedulePolicyType = schedulePolicyType ?? "Unknown";
        }
    }
}
