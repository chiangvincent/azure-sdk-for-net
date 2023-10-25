// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input for migrate. </summary>
    public partial class SiteRecoveryMigrateContent
    {
        /// <summary> Initializes a new instance of SiteRecoveryMigrateContent. </summary>
        /// <param name="properties"> Migrate input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryMigrateContent(SiteRecoveryMigrateProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Migrate input properties. </summary>
        internal SiteRecoveryMigrateProperties Properties { get; }
        /// <summary>
        /// The provider specific details.
        /// Please note <see cref="MigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtMigrateContent"/>.
        /// </summary>
        public MigrateProviderSpecificContent SiteRecoveryMigrateProviderSpecificDetails
        {
            get => Properties?.ProviderSpecificDetails;
        }
    }
}
