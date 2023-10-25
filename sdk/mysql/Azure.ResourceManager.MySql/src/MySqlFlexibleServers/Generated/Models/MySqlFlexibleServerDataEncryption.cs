// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The date encryption for cmk. </summary>
    public partial class MySqlFlexibleServerDataEncryption
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerDataEncryption. </summary>
        public MySqlFlexibleServerDataEncryption()
        {
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerDataEncryption. </summary>
        /// <param name="primaryUserAssignedIdentityId"> Primary user identity resource id. </param>
        /// <param name="primaryKeyUri"> Primary key uri. </param>
        /// <param name="geoBackupUserAssignedIdentityId"> Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup. </param>
        /// <param name="geoBackupKeyUri"> Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup. </param>
        /// <param name="encryptionType"> The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk. </param>
        internal MySqlFlexibleServerDataEncryption(ResourceIdentifier primaryUserAssignedIdentityId, Uri primaryKeyUri, ResourceIdentifier geoBackupUserAssignedIdentityId, Uri geoBackupKeyUri, MySqlFlexibleServerDataEncryptionType? encryptionType)
        {
            PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
            PrimaryKeyUri = primaryKeyUri;
            GeoBackupUserAssignedIdentityId = geoBackupUserAssignedIdentityId;
            GeoBackupKeyUri = geoBackupKeyUri;
            EncryptionType = encryptionType;
        }

        /// <summary> Primary user identity resource id. </summary>
        public ResourceIdentifier PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> Primary key uri. </summary>
        public Uri PrimaryKeyUri { get; set; }
        /// <summary> Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup. </summary>
        public ResourceIdentifier GeoBackupUserAssignedIdentityId { get; set; }
        /// <summary> Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup. </summary>
        public Uri GeoBackupKeyUri { get; set; }
        /// <summary> The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk. </summary>
        public MySqlFlexibleServerDataEncryptionType? EncryptionType { get; set; }
    }
}
