// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnServerConfiguration PolicyGroup member. </summary>
    public partial class VpnServerConfigurationPolicyGroupMember
    {
        /// <summary> Initializes a new instance of VpnServerConfigurationPolicyGroupMember. </summary>
        public VpnServerConfigurationPolicyGroupMember()
        {
        }

        /// <summary> Initializes a new instance of VpnServerConfigurationPolicyGroupMember. </summary>
        /// <param name="name"> Name of the VpnServerConfigurationPolicyGroupMember. </param>
        /// <param name="attributeType"> The Vpn Policy member attribute type. </param>
        /// <param name="attributeValue"> The value of Attribute used for this VpnServerConfigurationPolicyGroupMember. </param>
        internal VpnServerConfigurationPolicyGroupMember(string name, VpnPolicyMemberAttributeType? attributeType, string attributeValue)
        {
            Name = name;
            AttributeType = attributeType;
            AttributeValue = attributeValue;
        }

        /// <summary> Name of the VpnServerConfigurationPolicyGroupMember. </summary>
        public string Name { get; set; }
        /// <summary> The Vpn Policy member attribute type. </summary>
        public VpnPolicyMemberAttributeType? AttributeType { get; set; }
        /// <summary> The value of Attribute used for this VpnServerConfigurationPolicyGroupMember. </summary>
        public string AttributeValue { get; set; }
    }
}
