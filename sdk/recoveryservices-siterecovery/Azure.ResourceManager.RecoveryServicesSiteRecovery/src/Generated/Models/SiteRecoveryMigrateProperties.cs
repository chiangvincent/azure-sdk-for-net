// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Migrate input properties. </summary>
    public partial class SiteRecoveryMigrateProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryMigrateProperties. </summary>
        /// <param name="providerSpecificDetails">
        /// The provider specific details.
        /// Please note <see cref="MigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtMigrateContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerSpecificDetails"/> is null. </exception>
        public SiteRecoveryMigrateProperties(MigrateProviderSpecificContent providerSpecificDetails)
        {
            Argument.AssertNotNull(providerSpecificDetails, nameof(providerSpecificDetails));

            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// The provider specific details.
        /// Please note <see cref="MigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtMigrateContent"/>.
        /// </summary>
        public MigrateProviderSpecificContent ProviderSpecificDetails { get; }
    }
}
