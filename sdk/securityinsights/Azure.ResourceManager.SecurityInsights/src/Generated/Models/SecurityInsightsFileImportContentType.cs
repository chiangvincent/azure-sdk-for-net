// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The content type of this file. </summary>
    public readonly partial struct SecurityInsightsFileImportContentType : IEquatable<SecurityInsightsFileImportContentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFileImportContentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsFileImportContentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicIndicatorValue = "BasicIndicator";
        private const string StixIndicatorValue = "StixIndicator";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary> File containing records with the core fields of an indicator, plus the observables to construct the STIX pattern. </summary>
        public static SecurityInsightsFileImportContentType BasicIndicator { get; } = new SecurityInsightsFileImportContentType(BasicIndicatorValue);
        /// <summary> File containing STIX indicators. </summary>
        public static SecurityInsightsFileImportContentType StixIndicator { get; } = new SecurityInsightsFileImportContentType(StixIndicatorValue);
        /// <summary> File containing other records. </summary>
        public static SecurityInsightsFileImportContentType Unspecified { get; } = new SecurityInsightsFileImportContentType(UnspecifiedValue);
        /// <summary> Determines if two <see cref="SecurityInsightsFileImportContentType"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsFileImportContentType left, SecurityInsightsFileImportContentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsFileImportContentType"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsFileImportContentType left, SecurityInsightsFileImportContentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsFileImportContentType"/>. </summary>
        public static implicit operator SecurityInsightsFileImportContentType(string value) => new SecurityInsightsFileImportContentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsFileImportContentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsFileImportContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
