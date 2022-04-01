// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.HealthcareApis.FhirResourceUpdated event. </summary>
    public partial class HealthcareFhirResourceUpdatedEventData : HealthcareFhirResourceEventBaseProperties
    {
        /// <summary> Initializes a new instance of HealthcareFhirResourceUpdatedEventData. </summary>
        internal HealthcareFhirResourceUpdatedEventData()
        {
        }

        /// <summary> Initializes a new instance of HealthcareFhirResourceUpdatedEventData. </summary>
        /// <param name="resourceType"> Type of HL7 FHIR resource. </param>
        /// <param name="resourceFhirAccount"> Domain name of FHIR account for this resource. </param>
        /// <param name="resourceFhirId"> Id of HL7 FHIR resource. </param>
        /// <param name="resourceVersionId"> VersionId of HL7 FHIR resource. It changes when the resource is created, updated, or deleted(soft-deletion). </param>
        internal HealthcareFhirResourceUpdatedEventData(HealthcareFhirResourceType? resourceType, string resourceFhirAccount, string resourceFhirId, long? resourceVersionId) : base(resourceType, resourceFhirAccount, resourceFhirId, resourceVersionId)
        {
        }
    }
}
