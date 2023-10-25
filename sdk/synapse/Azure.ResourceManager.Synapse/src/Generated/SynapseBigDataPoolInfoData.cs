// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseBigDataPoolInfo data model.
    /// A Big Data pool
    /// </summary>
    public partial class SynapseBigDataPoolInfoData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SynapseBigDataPoolInfoData. </summary>
        /// <param name="location"> The location. </param>
        public SynapseBigDataPoolInfoData(AzureLocation location) : base(location)
        {
            CustomLibraries = new ChangeTrackingList<BigDataPoolLibraryInfo>();
        }

        /// <summary> Initializes a new instance of SynapseBigDataPoolInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The state of the Big Data pool. </param>
        /// <param name="autoScale"> Auto-scaling properties. </param>
        /// <param name="createdOn"> The time when the Big Data pool was created. </param>
        /// <param name="autoPause"> Auto-pausing properties. </param>
        /// <param name="isComputeIsolationEnabled"> Whether compute isolation is required or not. </param>
        /// <param name="isAutotuneEnabled"> Whether autotune is required or not. </param>
        /// <param name="isSessionLevelPackagesEnabled"> Whether session level packages enabled. </param>
        /// <param name="cacheSize"> The cache size. </param>
        /// <param name="dynamicExecutorAllocation"> Dynamic Executor Allocation. </param>
        /// <param name="sparkEventsFolder"> The Spark events folder. </param>
        /// <param name="nodeCount"> The number of nodes in the Big Data pool. </param>
        /// <param name="libraryRequirements"> Library version requirements. </param>
        /// <param name="customLibraries"> List of custom libraries/packages associated with the spark pool. </param>
        /// <param name="sparkConfigProperties"> Spark configuration file to specify additional properties. </param>
        /// <param name="sparkVersion"> The Apache Spark version. </param>
        /// <param name="defaultSparkLogFolder"> The default folder where Spark logs will be written. </param>
        /// <param name="nodeSize"> The level of compute power that each node in the Big Data pool has. </param>
        /// <param name="nodeSizeFamily"> The kind of nodes that the Big Data pool provides. </param>
        /// <param name="lastSucceededOn"> The time when the Big Data pool was updated successfully. </param>
        internal SynapseBigDataPoolInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, BigDataPoolAutoScaleProperties autoScale, DateTimeOffset? createdOn, BigDataPoolAutoPauseProperties autoPause, bool? isComputeIsolationEnabled, bool? isAutotuneEnabled, bool? isSessionLevelPackagesEnabled, int? cacheSize, SynapseDynamicExecutorAllocation dynamicExecutorAllocation, string sparkEventsFolder, int? nodeCount, BigDataPoolLibraryRequirements libraryRequirements, IList<BigDataPoolLibraryInfo> customLibraries, BigDataPoolSparkConfigProperties sparkConfigProperties, string sparkVersion, string defaultSparkLogFolder, BigDataPoolNodeSize? nodeSize, BigDataPoolNodeSizeFamily? nodeSizeFamily, DateTimeOffset? lastSucceededOn) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AutoScale = autoScale;
            CreatedOn = createdOn;
            AutoPause = autoPause;
            IsComputeIsolationEnabled = isComputeIsolationEnabled;
            IsAutotuneEnabled = isAutotuneEnabled;
            IsSessionLevelPackagesEnabled = isSessionLevelPackagesEnabled;
            CacheSize = cacheSize;
            DynamicExecutorAllocation = dynamicExecutorAllocation;
            SparkEventsFolder = sparkEventsFolder;
            NodeCount = nodeCount;
            LibraryRequirements = libraryRequirements;
            CustomLibraries = customLibraries;
            SparkConfigProperties = sparkConfigProperties;
            SparkVersion = sparkVersion;
            DefaultSparkLogFolder = defaultSparkLogFolder;
            NodeSize = nodeSize;
            NodeSizeFamily = nodeSizeFamily;
            LastSucceededOn = lastSucceededOn;
        }

        /// <summary> The state of the Big Data pool. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Auto-scaling properties. </summary>
        public BigDataPoolAutoScaleProperties AutoScale { get; set; }
        /// <summary> The time when the Big Data pool was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Auto-pausing properties. </summary>
        public BigDataPoolAutoPauseProperties AutoPause { get; set; }
        /// <summary> Whether compute isolation is required or not. </summary>
        public bool? IsComputeIsolationEnabled { get; set; }
        /// <summary> Whether autotune is required or not. </summary>
        public bool? IsAutotuneEnabled { get; set; }
        /// <summary> Whether session level packages enabled. </summary>
        public bool? IsSessionLevelPackagesEnabled { get; set; }
        /// <summary> The cache size. </summary>
        public int? CacheSize { get; set; }
        /// <summary> Dynamic Executor Allocation. </summary>
        public SynapseDynamicExecutorAllocation DynamicExecutorAllocation { get; set; }
        /// <summary> The Spark events folder. </summary>
        public string SparkEventsFolder { get; set; }
        /// <summary> The number of nodes in the Big Data pool. </summary>
        public int? NodeCount { get; set; }
        /// <summary> Library version requirements. </summary>
        public BigDataPoolLibraryRequirements LibraryRequirements { get; set; }
        /// <summary> List of custom libraries/packages associated with the spark pool. </summary>
        public IList<BigDataPoolLibraryInfo> CustomLibraries { get; }
        /// <summary> Spark configuration file to specify additional properties. </summary>
        public BigDataPoolSparkConfigProperties SparkConfigProperties { get; set; }
        /// <summary> The Apache Spark version. </summary>
        public string SparkVersion { get; set; }
        /// <summary> The default folder where Spark logs will be written. </summary>
        public string DefaultSparkLogFolder { get; set; }
        /// <summary> The level of compute power that each node in the Big Data pool has. </summary>
        public BigDataPoolNodeSize? NodeSize { get; set; }
        /// <summary> The kind of nodes that the Big Data pool provides. </summary>
        public BigDataPoolNodeSizeFamily? NodeSizeFamily { get; set; }
        /// <summary> The time when the Big Data pool was updated successfully. </summary>
        public DateTimeOffset? LastSucceededOn { get; }
    }
}
