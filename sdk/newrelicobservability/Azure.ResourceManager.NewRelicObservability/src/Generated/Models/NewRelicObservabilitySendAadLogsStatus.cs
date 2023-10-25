// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Indicates whether AAD logs are being sent. </summary>
    public readonly partial struct NewRelicObservabilitySendAadLogsStatus : IEquatable<NewRelicObservabilitySendAadLogsStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilitySendAadLogsStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NewRelicObservabilitySendAadLogsStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IsEnabledValue = "Enabled";
        private const string IsDisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static NewRelicObservabilitySendAadLogsStatus IsEnabled { get; } = new NewRelicObservabilitySendAadLogsStatus(IsEnabledValue);
        /// <summary> Disabled. </summary>
        public static NewRelicObservabilitySendAadLogsStatus IsDisabled { get; } = new NewRelicObservabilitySendAadLogsStatus(IsDisabledValue);
        /// <summary> Determines if two <see cref="NewRelicObservabilitySendAadLogsStatus"/> values are the same. </summary>
        public static bool operator ==(NewRelicObservabilitySendAadLogsStatus left, NewRelicObservabilitySendAadLogsStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NewRelicObservabilitySendAadLogsStatus"/> values are not the same. </summary>
        public static bool operator !=(NewRelicObservabilitySendAadLogsStatus left, NewRelicObservabilitySendAadLogsStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NewRelicObservabilitySendAadLogsStatus"/>. </summary>
        public static implicit operator NewRelicObservabilitySendAadLogsStatus(string value) => new NewRelicObservabilitySendAadLogsStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NewRelicObservabilitySendAadLogsStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NewRelicObservabilitySendAadLogsStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
