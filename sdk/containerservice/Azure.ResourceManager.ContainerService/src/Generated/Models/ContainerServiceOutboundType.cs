// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> This can only be set at cluster creation time and cannot be changed later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype). </summary>
    public readonly partial struct ContainerServiceOutboundType : IEquatable<ContainerServiceOutboundType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOutboundType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceOutboundType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LoadBalancerValue = "loadBalancer";
        private const string UserDefinedRoutingValue = "userDefinedRouting";
        private const string ManagedNatGatewayValue = "managedNATGateway";
        private const string UserAssignedNatGatewayValue = "userAssignedNATGateway";

        /// <summary> The load balancer is used for egress through an AKS assigned public IP. This supports Kubernetes services of type 'loadBalancer'. For more information see [outbound type loadbalancer](https://docs.microsoft.com/azure/aks/egress-outboundtype#outbound-type-of-loadbalancer). </summary>
        public static ContainerServiceOutboundType LoadBalancer { get; } = new ContainerServiceOutboundType(LoadBalancerValue);
        /// <summary> Egress paths must be defined by the user. This is an advanced scenario and requires proper network configuration. For more information see [outbound type userDefinedRouting](https://docs.microsoft.com/azure/aks/egress-outboundtype#outbound-type-of-userdefinedrouting). </summary>
        public static ContainerServiceOutboundType UserDefinedRouting { get; } = new ContainerServiceOutboundType(UserDefinedRoutingValue);
        /// <summary> The AKS-managed NAT gateway is used for egress. </summary>
        public static ContainerServiceOutboundType ManagedNatGateway { get; } = new ContainerServiceOutboundType(ManagedNatGatewayValue);
        /// <summary> The user-assigned NAT gateway associated to the cluster subnet is used for egress. This is an advanced scenario and requires proper network configuration. </summary>
        public static ContainerServiceOutboundType UserAssignedNatGateway { get; } = new ContainerServiceOutboundType(UserAssignedNatGatewayValue);
        /// <summary> Determines if two <see cref="ContainerServiceOutboundType"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceOutboundType left, ContainerServiceOutboundType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceOutboundType"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceOutboundType left, ContainerServiceOutboundType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServiceOutboundType"/>. </summary>
        public static implicit operator ContainerServiceOutboundType(string value) => new ContainerServiceOutboundType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceOutboundType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceOutboundType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
