// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryRecoveryPlanProperties
    {
        internal static SiteRecoveryRecoveryPlanProperties DeserializeSiteRecoveryRecoveryPlanProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<ResourceIdentifier> primaryFabricId = default;
            Optional<string> primaryFabricFriendlyName = default;
            Optional<ResourceIdentifier> recoveryFabricId = default;
            Optional<string> recoveryFabricFriendlyName = default;
            Optional<string> failoverDeploymentModel = default;
            Optional<IReadOnlyList<string>> replicationProviders = default;
            Optional<IReadOnlyList<string>> allowedOperations = default;
            Optional<DateTimeOffset> lastPlannedFailoverTime = default;
            Optional<DateTimeOffset> lastUnplannedFailoverTime = default;
            Optional<DateTimeOffset> lastTestFailoverTime = default;
            Optional<CurrentScenarioDetails> currentScenario = default;
            Optional<string> currentScenarioStatus = default;
            Optional<string> currentScenarioStatusDescription = default;
            Optional<IReadOnlyList<SiteRecoveryPlanGroup>> groups = default;
            Optional<IReadOnlyList<RecoveryPlanProviderSpecificDetails>> providerSpecificDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverDeploymentModel"u8))
                {
                    failoverDeploymentModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationProviders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    replicationProviders = array;
                    continue;
                }
                if (property.NameEquals("allowedOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOperations = array;
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPlannedFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUnplannedFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUnplannedFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTestFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTestFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentScenario"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentScenario = CurrentScenarioDetails.DeserializeCurrentScenarioDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("currentScenarioStatus"u8))
                {
                    currentScenarioStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentScenarioStatusDescription"u8))
                {
                    currentScenarioStatusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryPlanGroup> array = new List<SiteRecoveryPlanGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryPlanGroup.DeserializeSiteRecoveryPlanGroup(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificDetails> array = new List<RecoveryPlanProviderSpecificDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificDetails.DeserializeRecoveryPlanProviderSpecificDetails(item));
                    }
                    providerSpecificDetails = array;
                    continue;
                }
            }
            return new SiteRecoveryRecoveryPlanProperties(friendlyName.Value, primaryFabricId.Value, primaryFabricFriendlyName.Value, recoveryFabricId.Value, recoveryFabricFriendlyName.Value, failoverDeploymentModel.Value, Optional.ToList(replicationProviders), Optional.ToList(allowedOperations), Optional.ToNullable(lastPlannedFailoverTime), Optional.ToNullable(lastUnplannedFailoverTime), Optional.ToNullable(lastTestFailoverTime), currentScenario.Value, currentScenarioStatus.Value, currentScenarioStatusDescription.Value, Optional.ToList(groups), Optional.ToList(providerSpecificDetails));
        }
    }
}
