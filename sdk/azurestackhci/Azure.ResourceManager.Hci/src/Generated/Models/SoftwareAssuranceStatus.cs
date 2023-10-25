// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Status of the Software Assurance for the cluster. </summary>
    public readonly partial struct SoftwareAssuranceStatus : IEquatable<SoftwareAssuranceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SoftwareAssuranceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SoftwareAssuranceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static SoftwareAssuranceStatus Enabled { get; } = new SoftwareAssuranceStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SoftwareAssuranceStatus Disabled { get; } = new SoftwareAssuranceStatus(DisabledValue);
        /// <summary> Determines if two <see cref="SoftwareAssuranceStatus"/> values are the same. </summary>
        public static bool operator ==(SoftwareAssuranceStatus left, SoftwareAssuranceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SoftwareAssuranceStatus"/> values are not the same. </summary>
        public static bool operator !=(SoftwareAssuranceStatus left, SoftwareAssuranceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SoftwareAssuranceStatus"/>. </summary>
        public static implicit operator SoftwareAssuranceStatus(string value) => new SoftwareAssuranceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SoftwareAssuranceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SoftwareAssuranceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
