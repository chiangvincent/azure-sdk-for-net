// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class ArmApplicationArtifactTypeExtensions
    {
        public static string ToSerialString(this ArmApplicationArtifactType value) => value switch
        {
            ArmApplicationArtifactType.NotSpecified => "NotSpecified",
            ArmApplicationArtifactType.Template => "Template",
            ArmApplicationArtifactType.Custom => "Custom",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArmApplicationArtifactType value.")
        };

        public static ArmApplicationArtifactType ToArmApplicationArtifactType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSpecified")) return ArmApplicationArtifactType.NotSpecified;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Template")) return ArmApplicationArtifactType.Template;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Custom")) return ArmApplicationArtifactType.Custom;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArmApplicationArtifactType value.");
        }
    }
}
