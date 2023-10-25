// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A class representing the DataLakeStoreAccount data model.
    /// Data Lake Store account information.
    /// </summary>
    public partial class DataLakeStoreAccountData : ResourceData
    {
        /// <summary> Initializes a new instance of DataLakeStoreAccountData. </summary>
        internal DataLakeStoreAccountData()
        {
            FirewallRules = new ChangeTrackingList<DataLakeStoreFirewallRuleData>();
            VirtualNetworkRules = new ChangeTrackingList<DataLakeStoreVirtualNetworkRuleData>();
            TrustedIdProviders = new ChangeTrackingList<DataLakeStoreTrustedIdProviderData>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DataLakeStoreAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The Key Vault encryption identity, if any. Current supported identity types: SystemAssigned. </param>
        /// <param name="accountId"> The unique identifier associated with this Data Lake Store account. </param>
        /// <param name="provisioningState"> The provisioning status of the Data Lake Store account. </param>
        /// <param name="state"> The state of the Data Lake Store account. </param>
        /// <param name="createdOn"> The account creation time. </param>
        /// <param name="lastModifiedOn"> The account last modified time. </param>
        /// <param name="endpoint"> The full CName endpoint for this account. </param>
        /// <param name="defaultGroup"> The default owner group for all new folders and files created in the Data Lake Store account. </param>
        /// <param name="encryptionConfig"> The Key Vault encryption configuration. </param>
        /// <param name="encryptionState"> The current state of encryption for this Data Lake Store account. </param>
        /// <param name="encryptionProvisioningState"> The current state of encryption provisioning for this Data Lake Store account. </param>
        /// <param name="firewallRules"> The list of firewall rules associated with this Data Lake Store account. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules associated with this Data Lake Store account. </param>
        /// <param name="firewallState"> The current state of the IP address firewall for this Data Lake Store account. </param>
        /// <param name="firewallAllowAzureIPs"> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </param>
        /// <param name="trustedIdProviders"> The list of trusted identity providers associated with this Data Lake Store account. </param>
        /// <param name="trustedIdProviderState"> The current state of the trusted identity provider feature for this Data Lake Store account. </param>
        /// <param name="newTier"> The commitment tier to use for next month. </param>
        /// <param name="currentTier"> The commitment tier in use for the current month. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        internal DataLakeStoreAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, Guid? accountId, DataLakeStoreAccountStatus? provisioningState, DataLakeStoreAccountState? state, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string endpoint, string defaultGroup, DataLakeStoreAccountEncryptionConfig encryptionConfig, DataLakeStoreEncryptionState? encryptionState, DataLakeStoreEncryptionProvisioningState? encryptionProvisioningState, IReadOnlyList<DataLakeStoreFirewallRuleData> firewallRules, IReadOnlyList<DataLakeStoreVirtualNetworkRuleData> virtualNetworkRules, DataLakeStoreFirewallState? firewallState, DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs, IReadOnlyList<DataLakeStoreTrustedIdProviderData> trustedIdProviders, DataLakeStoreTrustedIdProviderState? trustedIdProviderState, DataLakeStoreCommitmentTierType? newTier, DataLakeStoreCommitmentTierType? currentTier, AzureLocation? location, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            AccountId = accountId;
            ProvisioningState = provisioningState;
            State = state;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Endpoint = endpoint;
            DefaultGroup = defaultGroup;
            EncryptionConfig = encryptionConfig;
            EncryptionState = encryptionState;
            EncryptionProvisioningState = encryptionProvisioningState;
            FirewallRules = firewallRules;
            VirtualNetworkRules = virtualNetworkRules;
            FirewallState = firewallState;
            FirewallAllowAzureIPs = firewallAllowAzureIPs;
            TrustedIdProviders = trustedIdProviders;
            TrustedIdProviderState = trustedIdProviderState;
            NewTier = newTier;
            CurrentTier = currentTier;
            Location = location;
            Tags = tags;
        }

        /// <summary> The Key Vault encryption identity, if any. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; }
        /// <summary> The unique identifier associated with this Data Lake Store account. </summary>
        public Guid? AccountId { get; }
        /// <summary> The provisioning status of the Data Lake Store account. </summary>
        public DataLakeStoreAccountStatus? ProvisioningState { get; }
        /// <summary> The state of the Data Lake Store account. </summary>
        public DataLakeStoreAccountState? State { get; }
        /// <summary> The account creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The account last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The full CName endpoint for this account. </summary>
        public string Endpoint { get; }
        /// <summary> The default owner group for all new folders and files created in the Data Lake Store account. </summary>
        public string DefaultGroup { get; }
        /// <summary> The Key Vault encryption configuration. </summary>
        public DataLakeStoreAccountEncryptionConfig EncryptionConfig { get; }
        /// <summary> The current state of encryption for this Data Lake Store account. </summary>
        public DataLakeStoreEncryptionState? EncryptionState { get; }
        /// <summary> The current state of encryption provisioning for this Data Lake Store account. </summary>
        public DataLakeStoreEncryptionProvisioningState? EncryptionProvisioningState { get; }
        /// <summary> The list of firewall rules associated with this Data Lake Store account. </summary>
        public IReadOnlyList<DataLakeStoreFirewallRuleData> FirewallRules { get; }
        /// <summary> The list of virtual network rules associated with this Data Lake Store account. </summary>
        public IReadOnlyList<DataLakeStoreVirtualNetworkRuleData> VirtualNetworkRules { get; }
        /// <summary> The current state of the IP address firewall for this Data Lake Store account. </summary>
        public DataLakeStoreFirewallState? FirewallState { get; }
        /// <summary> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </summary>
        public DataLakeStoreFirewallAllowAzureIPsState? FirewallAllowAzureIPs { get; }
        /// <summary> The list of trusted identity providers associated with this Data Lake Store account. </summary>
        public IReadOnlyList<DataLakeStoreTrustedIdProviderData> TrustedIdProviders { get; }
        /// <summary> The current state of the trusted identity provider feature for this Data Lake Store account. </summary>
        public DataLakeStoreTrustedIdProviderState? TrustedIdProviderState { get; }
        /// <summary> The commitment tier to use for next month. </summary>
        public DataLakeStoreCommitmentTierType? NewTier { get; }
        /// <summary> The commitment tier in use for the current month. </summary>
        public DataLakeStoreCommitmentTierType? CurrentTier { get; }
        /// <summary> The resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
