// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class CommunityGalleryImageData
    {
        internal static CommunityGalleryImageData DeserializeCommunityGalleryImageData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<ResourceType> type = default;
            Optional<SupportedOperatingSystemType> osType = default;
            Optional<OperatingSystemStateType> osState = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<CommunityGalleryImageIdentifier> identifier = default;
            Optional<RecommendedMachineConfiguration> recommended = default;
            Optional<Disallowed> disallowed = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<IReadOnlyList<GalleryImageFeature>> features = default;
            Optional<ImagePurchasePlan> purchasePlan = default;
            Optional<ArchitectureType> architecture = default;
            Optional<Uri> privacyStatementUri = default;
            Optional<string> eula = default;
            Optional<string> uniqueId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = property0.Value.GetString().ToSupportedOperatingSystemType();
                            continue;
                        }
                        if (property0.NameEquals("osState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osState = property0.Value.GetString().ToOperatingSystemStateType();
                            continue;
                        }
                        if (property0.NameEquals("endOfLifeDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endOfLifeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = CommunityGalleryImageIdentifier.DeserializeCommunityGalleryImageIdentifier(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("recommended"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommended = RecommendedMachineConfiguration.DeserializeRecommendedMachineConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("disallowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disallowed = Disallowed.DeserializeDisallowed(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("features"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GalleryImageFeature> array = new List<GalleryImageFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GalleryImageFeature.DeserializeGalleryImageFeature(item));
                            }
                            features = array;
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasePlan = ImagePurchasePlan.DeserializeImagePurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("architecture"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            architecture = new ArchitectureType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privacyStatementUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyStatementUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eula"u8))
                        {
                            eula = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CommunityGalleryImageData(name.Value, Optional.ToNullable(location), Optional.ToNullable(type), uniqueId.Value, Optional.ToNullable(osType), Optional.ToNullable(osState), Optional.ToNullable(endOfLifeDate), identifier.Value, recommended.Value, disallowed.Value, Optional.ToNullable(hyperVGeneration), Optional.ToList(features), purchasePlan.Value, Optional.ToNullable(architecture), privacyStatementUri.Value, eula.Value);
        }
    }
}
