// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines a managed rule set for Exclusions. </summary>
    public partial class ExclusionManagedRuleSet
    {
        /// <summary> Initializes a new instance of ExclusionManagedRuleSet. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetType"/> or <paramref name="ruleSetVersion"/> is null. </exception>
        public ExclusionManagedRuleSet(string ruleSetType, string ruleSetVersion)
        {
            Argument.AssertNotNull(ruleSetType, nameof(ruleSetType));
            Argument.AssertNotNull(ruleSetVersion, nameof(ruleSetVersion));

            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = new ChangeTrackingList<ExclusionManagedRuleGroup>();
        }

        /// <summary> Initializes a new instance of ExclusionManagedRuleSet. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <param name="ruleGroups"> Defines the rule groups to apply to the rule set. </param>
        internal ExclusionManagedRuleSet(string ruleSetType, string ruleSetVersion, IList<ExclusionManagedRuleGroup> ruleGroups)
        {
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
        }

        /// <summary> Defines the rule set type to use. </summary>
        public string RuleSetType { get; set; }
        /// <summary> Defines the version of the rule set to use. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> Defines the rule groups to apply to the rule set. </summary>
        public IList<ExclusionManagedRuleGroup> RuleGroups { get; }
    }
}
