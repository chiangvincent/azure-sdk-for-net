// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Specifies the mode of VM Guest patch assessment for the IaaS virtual machine. </summary>
    public readonly partial struct ComputeFleetWindowsPatchAssessmentMode : IEquatable<ComputeFleetWindowsPatchAssessmentMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetWindowsPatchAssessmentMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetWindowsPatchAssessmentMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImageDefaultValue = "ImageDefault";
        private const string AutomaticByPlatformValue = "AutomaticByPlatform";

        /// <summary> You control the timing of patch assessments on a virtual machine. </summary>
        public static ComputeFleetWindowsPatchAssessmentMode ImageDefault { get; } = new ComputeFleetWindowsPatchAssessmentMode(ImageDefaultValue);
        /// <summary> The platform will trigger periodic patch assessments. The property provisionVMAgent must be true. </summary>
        public static ComputeFleetWindowsPatchAssessmentMode AutomaticByPlatform { get; } = new ComputeFleetWindowsPatchAssessmentMode(AutomaticByPlatformValue);
        /// <summary> Determines if two <see cref="ComputeFleetWindowsPatchAssessmentMode"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetWindowsPatchAssessmentMode left, ComputeFleetWindowsPatchAssessmentMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetWindowsPatchAssessmentMode"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetWindowsPatchAssessmentMode left, ComputeFleetWindowsPatchAssessmentMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeFleetWindowsPatchAssessmentMode"/>. </summary>
        public static implicit operator ComputeFleetWindowsPatchAssessmentMode(string value) => new ComputeFleetWindowsPatchAssessmentMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetWindowsPatchAssessmentMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetWindowsPatchAssessmentMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
