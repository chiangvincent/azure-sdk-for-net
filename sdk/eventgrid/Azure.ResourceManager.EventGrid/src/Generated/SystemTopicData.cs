// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the SystemTopic data model.
    /// EventGrid System Topic.
    /// </summary>
    public partial class SystemTopicData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SystemTopicData. </summary>
        /// <param name="location"> The location. </param>
        public SystemTopicData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SystemTopicData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity information for the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the system topic. </param>
        /// <param name="source"> Source for the system topic. </param>
        /// <param name="topicType"> TopicType for the system topic. </param>
        /// <param name="metricResourceId"> Metric resource id for the system topic. </param>
        internal SystemTopicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, EventGridResourceProvisioningState? provisioningState, ResourceIdentifier source, string topicType, Guid? metricResourceId) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            Source = source;
            TopicType = topicType;
            MetricResourceId = metricResourceId;
        }

        /// <summary> Identity information for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the system topic. </summary>
        public EventGridResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Source for the system topic. </summary>
        public ResourceIdentifier Source { get; set; }
        /// <summary> TopicType for the system topic. </summary>
        public string TopicType { get; set; }
        /// <summary> Metric resource id for the system topic. </summary>
        public Guid? MetricResourceId { get; }
    }
}
