// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Azure Firewall Packet Capture Parameters resource. </summary>
    public partial class FirewallPacketCaptureContent : NetworkSubResource
    {
        /// <summary> Initializes a new instance of FirewallPacketCaptureContent. </summary>
        public FirewallPacketCaptureContent()
        {
            Flags = new ChangeTrackingList<AzureFirewallPacketCaptureFlags>();
            Filters = new ChangeTrackingList<AzureFirewallPacketCaptureRule>();
        }

        /// <summary> Initializes a new instance of FirewallPacketCaptureContent. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="durationInSeconds"> Duration of packet capture in seconds. </param>
        /// <param name="numberOfPacketsToCapture"> Number of packets to be captured. </param>
        /// <param name="sasUri"> Upload capture location. </param>
        /// <param name="fileName"> Name of file to be uploaded to sasURL. </param>
        /// <param name="protocol"> The protocol of packets to capture. </param>
        /// <param name="flags"> The tcp-flag type to be captured. Used with protocol TCP. </param>
        /// <param name="filters"> Rules to filter packet captures. </param>
        internal FirewallPacketCaptureContent(ResourceIdentifier id, int? durationInSeconds, int? numberOfPacketsToCapture, Uri sasUri, string fileName, AzureFirewallNetworkRuleProtocol? protocol, IList<AzureFirewallPacketCaptureFlags> flags, IList<AzureFirewallPacketCaptureRule> filters) : base(id)
        {
            DurationInSeconds = durationInSeconds;
            NumberOfPacketsToCapture = numberOfPacketsToCapture;
            SasUri = sasUri;
            FileName = fileName;
            Protocol = protocol;
            Flags = flags;
            Filters = filters;
        }

        /// <summary> Duration of packet capture in seconds. </summary>
        public int? DurationInSeconds { get; set; }
        /// <summary> Number of packets to be captured. </summary>
        public int? NumberOfPacketsToCapture { get; set; }
        /// <summary> Upload capture location. </summary>
        public Uri SasUri { get; set; }
        /// <summary> Name of file to be uploaded to sasURL. </summary>
        public string FileName { get; set; }
        /// <summary> The protocol of packets to capture. </summary>
        public AzureFirewallNetworkRuleProtocol? Protocol { get; set; }
        /// <summary> The tcp-flag type to be captured. Used with protocol TCP. </summary>
        public IList<AzureFirewallPacketCaptureFlags> Flags { get; }
        /// <summary> Rules to filter packet captures. </summary>
        public IList<AzureFirewallPacketCaptureRule> Filters { get; }
    }
}
