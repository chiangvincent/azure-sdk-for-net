// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set network profile's network
    /// configurations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetUpdateNetworkConfiguration : IResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateNetworkConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetUpdateNetworkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateNetworkConfiguration class.
        /// </summary>
        /// <param name="name">The network configuration name.</param>
        /// <param name="primary">Whether this is a primary NIC on a virtual
        /// machine.</param>
        /// <param name="enableAcceleratedNetworking">Specifies whether the
        /// network interface is accelerated networking-enabled.</param>
        /// <param name="disableTcpStateTracking">Specifies whether the network
        /// interface is disabled for tcp state tracking.</param>
        /// <param name="enableFpga">Specifies whether the network interface is
        /// FPGA networking-enabled.</param>
        /// <param name="networkSecurityGroup">The network security
        /// group.</param>
        /// <param name="dnsSettings">The dns settings to be applied on the
        /// network interfaces.</param>
        /// <param name="ipConfigurations">The virtual machine scale set IP
        /// Configuration.</param>
        /// <param name="enableIPForwarding">Whether IP forwarding enabled on
        /// this NIC.</param>
        /// <param name="deleteOption">Specify what happens to the network
        /// interface when the VM is deleted. Possible values include:
        /// 'Delete', 'Detach'</param>
        public VirtualMachineScaleSetUpdateNetworkConfiguration(string name = default(string), bool? primary = default(bool?), bool? enableAcceleratedNetworking = default(bool?), bool? disableTcpStateTracking = default(bool?), bool? enableFpga = default(bool?), SubResource networkSecurityGroup = default(SubResource), VirtualMachineScaleSetNetworkConfigurationDnsSettings dnsSettings = default(VirtualMachineScaleSetNetworkConfigurationDnsSettings), IList<VirtualMachineScaleSetUpdateIPConfiguration> ipConfigurations = default(IList<VirtualMachineScaleSetUpdateIPConfiguration>), bool? enableIPForwarding = default(bool?), string deleteOption = default(string))
        {
            Name = name;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            DisableTcpStateTracking = disableTcpStateTracking;
            EnableFpga = enableFpga;
            NetworkSecurityGroup = networkSecurityGroup;
            DnsSettings = dnsSettings;
            IpConfigurations = ipConfigurations;
            EnableIPForwarding = enableIPForwarding;
            DeleteOption = deleteOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the network configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether this is a primary NIC on a virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the network interface is accelerated
        /// networking-enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAcceleratedNetworking")]
        public bool? EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the network interface is disabled
        /// for tcp state tracking.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableTcpStateTracking")]
        public bool? DisableTcpStateTracking { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the network interface is FPGA
        /// networking-enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableFpga")]
        public bool? EnableFpga { get; set; }

        /// <summary>
        /// Gets or sets the network security group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets the dns settings to be applied on the network
        /// interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set IP Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<VirtualMachineScaleSetUpdateIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets whether IP forwarding enabled on this NIC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableIPForwarding")]
        public bool? EnableIPForwarding { get; set; }

        /// <summary>
        /// Gets or sets specify what happens to the network interface when the
        /// VM is deleted. Possible values include: 'Delete', 'Detach'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteOption")]
        public string DeleteOption { get; set; }

    }
}
