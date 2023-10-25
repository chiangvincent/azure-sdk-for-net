// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppSourceControl data model.
    /// Container App SourceControl.
    /// </summary>
    public partial class ContainerAppSourceControlData : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerAppSourceControlData. </summary>
        public ContainerAppSourceControlData()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppSourceControlData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="operationState"> Current provisioning State of the operation. </param>
        /// <param name="repoUri"> The repo url which will be integrated to ContainerApp. </param>
        /// <param name="branch"> The branch which will trigger the auto deployment. </param>
        /// <param name="gitHubActionConfiguration">
        /// Container App Revision Template with all possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </param>
        internal ContainerAppSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ContainerAppSourceControlOperationState? operationState, Uri repoUri, string branch, ContainerAppGitHubActionConfiguration gitHubActionConfiguration) : base(id, name, resourceType, systemData)
        {
            OperationState = operationState;
            RepoUri = repoUri;
            Branch = branch;
            GitHubActionConfiguration = gitHubActionConfiguration;
        }

        /// <summary> Current provisioning State of the operation. </summary>
        public ContainerAppSourceControlOperationState? OperationState { get; }
        /// <summary> The repo url which will be integrated to ContainerApp. </summary>
        public Uri RepoUri { get; set; }
        /// <summary> The branch which will trigger the auto deployment. </summary>
        public string Branch { get; set; }
        /// <summary>
        /// Container App Revision Template with all possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </summary>
        public ContainerAppGitHubActionConfiguration GitHubActionConfiguration { get; set; }
    }
}
