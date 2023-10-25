// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class ErrorDeploymentTypeExtensions
    {
        public static string ToSerialString(this ErrorDeploymentType value) => value switch
        {
            ErrorDeploymentType.LastSuccessful => "LastSuccessful",
            ErrorDeploymentType.SpecificDeployment => "SpecificDeployment",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ErrorDeploymentType value.")
        };

        public static ErrorDeploymentType ToErrorDeploymentType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LastSuccessful")) return ErrorDeploymentType.LastSuccessful;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SpecificDeployment")) return ErrorDeploymentType.SpecificDeployment;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ErrorDeploymentType value.");
        }
    }
}
