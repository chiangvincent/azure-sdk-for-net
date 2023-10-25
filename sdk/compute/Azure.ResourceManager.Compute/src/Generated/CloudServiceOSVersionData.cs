// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CloudServiceOSVersion data model.
    /// Describes a cloud service OS version.
    /// </summary>
    public partial class CloudServiceOSVersionData : ResourceData
    {
        /// <summary> Initializes a new instance of CloudServiceOSVersionData. </summary>
        internal CloudServiceOSVersionData()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceOSVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="family"> The family of this OS version. </param>
        /// <param name="familyLabel"> The family label of this OS version. </param>
        /// <param name="version"> The OS version. </param>
        /// <param name="label"> The OS version label. </param>
        /// <param name="isDefault"> Specifies whether this is the default OS version for its family. </param>
        /// <param name="isActive"> Specifies whether this OS version is active. </param>
        internal CloudServiceOSVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string family, string familyLabel, string version, string label, bool? isDefault, bool? isActive) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Family = family;
            FamilyLabel = familyLabel;
            Version = version;
            Label = label;
            IsDefault = isDefault;
            IsActive = isActive;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The family of this OS version. </summary>
        public string Family { get; }
        /// <summary> The family label of this OS version. </summary>
        public string FamilyLabel { get; }
        /// <summary> The OS version. </summary>
        public string Version { get; }
        /// <summary> The OS version label. </summary>
        public string Label { get; }
        /// <summary> Specifies whether this is the default OS version for its family. </summary>
        public bool? IsDefault { get; }
        /// <summary> Specifies whether this OS version is active. </summary>
        public bool? IsActive { get; }
    }
}
