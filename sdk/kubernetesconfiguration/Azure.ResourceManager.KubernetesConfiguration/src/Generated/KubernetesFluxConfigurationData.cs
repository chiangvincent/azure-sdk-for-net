// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary>
    /// A class representing the KubernetesFluxConfiguration data model.
    /// The Flux Configuration object returned in Get &amp; Put response.
    /// </summary>
    public partial class KubernetesFluxConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of KubernetesFluxConfigurationData. </summary>
        public KubernetesFluxConfigurationData()
        {
            Kustomizations = new ChangeTrackingDictionary<string, Kustomization>();
            ConfigurationProtectedSettings = new ChangeTrackingDictionary<string, string>();
            Statuses = new ChangeTrackingList<KubernetesObjectStatus>();
        }

        /// <summary> Initializes a new instance of KubernetesFluxConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> Scope at which the operator will be installed. </param>
        /// <param name="namespace"> The namespace to which this configuration is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only. </param>
        /// <param name="sourceKind"> Source Kind to pull the configuration data from. </param>
        /// <param name="isReconciliationSuspended"> Whether this configuration should suspend its reconciliation of its kustomizations and sources. </param>
        /// <param name="gitRepository"> Parameters to reconcile to the GitRepository source kind type. </param>
        /// <param name="bucket"> Parameters to reconcile to the Bucket source kind type. </param>
        /// <param name="azureBlob"> Parameters to reconcile to the AzureBlob source kind type. </param>
        /// <param name="kustomizations"> Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster. </param>
        /// <param name="configurationProtectedSettings"> Key-value pairs of protected configuration settings for the configuration. </param>
        /// <param name="statuses"> Statuses of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects provisioned by the fluxConfiguration. </param>
        /// <param name="repositoryPublicKey"> Public Key associated with this fluxConfiguration (either generated within the cluster or provided by the user). </param>
        /// <param name="sourceSyncedCommitId"> Branch and/or SHA of the source commit synced with the cluster. </param>
        /// <param name="sourceUpdatedOn"> Datetime the fluxConfiguration synced its source on the cluster. </param>
        /// <param name="statusUpdatedOn"> Datetime the fluxConfiguration synced its status on the cluster with Azure. </param>
        /// <param name="complianceState"> Combined status of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects. </param>
        /// <param name="provisioningState"> Status of the creation of the fluxConfiguration. </param>
        /// <param name="errorMessage"> Error message returned to the user in the case of provisioning failure. </param>
        internal KubernetesFluxConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, KubernetesConfigurationScope? scope, string @namespace, KubernetesConfigurationSourceKind? sourceKind, bool? isReconciliationSuspended, KubernetesGitRepository gitRepository, KubernetesBucket bucket, KubernetesAzureBlob azureBlob, IDictionary<string, Kustomization> kustomizations, IDictionary<string, string> configurationProtectedSettings, IReadOnlyList<KubernetesObjectStatus> statuses, string repositoryPublicKey, string sourceSyncedCommitId, DateTimeOffset? sourceUpdatedOn, DateTimeOffset? statusUpdatedOn, KubernetesFluxComplianceState? complianceState, KubernetesConfigurationProvisioningState? provisioningState, string errorMessage) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            Namespace = @namespace;
            SourceKind = sourceKind;
            IsReconciliationSuspended = isReconciliationSuspended;
            GitRepository = gitRepository;
            Bucket = bucket;
            AzureBlob = azureBlob;
            Kustomizations = kustomizations;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            Statuses = statuses;
            RepositoryPublicKey = repositoryPublicKey;
            SourceSyncedCommitId = sourceSyncedCommitId;
            SourceUpdatedOn = sourceUpdatedOn;
            StatusUpdatedOn = statusUpdatedOn;
            ComplianceState = complianceState;
            ProvisioningState = provisioningState;
            ErrorMessage = errorMessage;
        }

        /// <summary> Scope at which the operator will be installed. </summary>
        public KubernetesConfigurationScope? Scope { get; set; }
        /// <summary> The namespace to which this configuration is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only. </summary>
        public string Namespace { get; set; }
        /// <summary> Source Kind to pull the configuration data from. </summary>
        public KubernetesConfigurationSourceKind? SourceKind { get; set; }
        /// <summary> Whether this configuration should suspend its reconciliation of its kustomizations and sources. </summary>
        public bool? IsReconciliationSuspended { get; set; }
        /// <summary> Parameters to reconcile to the GitRepository source kind type. </summary>
        public KubernetesGitRepository GitRepository { get; set; }
        /// <summary> Parameters to reconcile to the Bucket source kind type. </summary>
        public KubernetesBucket Bucket { get; set; }
        /// <summary> Parameters to reconcile to the AzureBlob source kind type. </summary>
        public KubernetesAzureBlob AzureBlob { get; set; }
        /// <summary> Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster. </summary>
        public IDictionary<string, Kustomization> Kustomizations { get; set; }
        /// <summary> Key-value pairs of protected configuration settings for the configuration. </summary>
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }
        /// <summary> Statuses of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects provisioned by the fluxConfiguration. </summary>
        public IReadOnlyList<KubernetesObjectStatus> Statuses { get; }
        /// <summary> Public Key associated with this fluxConfiguration (either generated within the cluster or provided by the user). </summary>
        public string RepositoryPublicKey { get; }
        /// <summary> Branch and/or SHA of the source commit synced with the cluster. </summary>
        public string SourceSyncedCommitId { get; }
        /// <summary> Datetime the fluxConfiguration synced its source on the cluster. </summary>
        public DateTimeOffset? SourceUpdatedOn { get; }
        /// <summary> Datetime the fluxConfiguration synced its status on the cluster with Azure. </summary>
        public DateTimeOffset? StatusUpdatedOn { get; }
        /// <summary> Combined status of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects. </summary>
        public KubernetesFluxComplianceState? ComplianceState { get; }
        /// <summary> Status of the creation of the fluxConfiguration. </summary>
        public KubernetesConfigurationProvisioningState? ProvisioningState { get; }
        /// <summary> Error message returned to the user in the case of provisioning failure. </summary>
        public string ErrorMessage { get; }
    }
}
