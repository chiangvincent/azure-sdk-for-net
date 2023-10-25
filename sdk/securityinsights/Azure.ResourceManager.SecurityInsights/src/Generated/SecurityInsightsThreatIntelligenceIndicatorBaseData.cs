// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsThreatIntelligenceIndicatorBase data model.
    /// Threat intelligence information object.
    /// Please note <see cref="SecurityInsightsThreatIntelligenceIndicatorBaseData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SecurityInsightsThreatIntelligenceIndicatorData"/>.
    /// </summary>
    public partial class SecurityInsightsThreatIntelligenceIndicatorBaseData : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityInsightsThreatIntelligenceIndicatorBaseData. </summary>
        public SecurityInsightsThreatIntelligenceIndicatorBaseData()
        {
        }

        /// <summary> Initializes a new instance of SecurityInsightsThreatIntelligenceIndicatorBaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal SecurityInsightsThreatIntelligenceIndicatorBaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ThreatIntelligenceResourceInnerKind kind, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
        }

        /// <summary> The kind of the entity. </summary>
        internal ThreatIntelligenceResourceInnerKind Kind { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
