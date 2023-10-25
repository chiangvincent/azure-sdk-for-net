// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Container with items backed up using MAB backup engine. </summary>
    public partial class MabContainer : BackupGenericProtectionContainer
    {
        /// <summary> Initializes a new instance of MabContainer. </summary>
        public MabContainer()
        {
            MabContainerHealthDetails = new ChangeTrackingList<MabContainerHealthDetails>();
            ContainerType = ProtectableContainerType.Windows;
        }

        /// <summary> Initializes a new instance of MabContainer. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        /// <param name="canReRegister"> Can the container be registered one more time. </param>
        /// <param name="containerId"> ContainerID represents the container. </param>
        /// <param name="protectedItemCount"> Number of items backed up in this container. </param>
        /// <param name="agentVersion"> Agent version of this container. </param>
        /// <param name="extendedInfo"> Additional information for this container. </param>
        /// <param name="mabContainerHealthDetails"> Health details on this mab container. </param>
        /// <param name="containerHealthState"> Health state of mab container. </param>
        internal MabContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType, bool? canReRegister, long? containerId, long? protectedItemCount, string agentVersion, MabContainerExtendedInfo extendedInfo, IList<MabContainerHealthDetails> mabContainerHealthDetails, string containerHealthState) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType)
        {
            CanReRegister = canReRegister;
            ContainerId = containerId;
            ProtectedItemCount = protectedItemCount;
            AgentVersion = agentVersion;
            ExtendedInfo = extendedInfo;
            MabContainerHealthDetails = mabContainerHealthDetails;
            ContainerHealthState = containerHealthState;
            ContainerType = containerType;
        }

        /// <summary> Can the container be registered one more time. </summary>
        public bool? CanReRegister { get; set; }
        /// <summary> ContainerID represents the container. </summary>
        public long? ContainerId { get; set; }
        /// <summary> Number of items backed up in this container. </summary>
        public long? ProtectedItemCount { get; set; }
        /// <summary> Agent version of this container. </summary>
        public string AgentVersion { get; set; }
        /// <summary> Additional information for this container. </summary>
        public MabContainerExtendedInfo ExtendedInfo { get; set; }
        /// <summary> Health details on this mab container. </summary>
        public IList<MabContainerHealthDetails> MabContainerHealthDetails { get; }
        /// <summary> Health state of mab container. </summary>
        public string ContainerHealthState { get; set; }
    }
}
