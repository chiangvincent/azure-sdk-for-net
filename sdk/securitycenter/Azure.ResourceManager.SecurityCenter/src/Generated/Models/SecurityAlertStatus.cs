// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The life cycle status of the alert. </summary>
    public readonly partial struct SecurityAlertStatus : IEquatable<SecurityAlertStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAlertStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAlertStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string InProgressValue = "InProgress";
        private const string ResolvedValue = "Resolved";
        private const string DismissedValue = "Dismissed";

        /// <summary> An alert which doesn't specify a value is assigned the status 'Active'. </summary>
        public static SecurityAlertStatus Active { get; } = new SecurityAlertStatus(ActiveValue);
        /// <summary> An alert which is in handling state. </summary>
        public static SecurityAlertStatus InProgress { get; } = new SecurityAlertStatus(InProgressValue);
        /// <summary> Alert closed after handling. </summary>
        public static SecurityAlertStatus Resolved { get; } = new SecurityAlertStatus(ResolvedValue);
        /// <summary> Alert dismissed as false positive. </summary>
        public static SecurityAlertStatus Dismissed { get; } = new SecurityAlertStatus(DismissedValue);
        /// <summary> Determines if two <see cref="SecurityAlertStatus"/> values are the same. </summary>
        public static bool operator ==(SecurityAlertStatus left, SecurityAlertStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAlertStatus"/> values are not the same. </summary>
        public static bool operator !=(SecurityAlertStatus left, SecurityAlertStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityAlertStatus"/>. </summary>
        public static implicit operator SecurityAlertStatus(string value) => new SecurityAlertStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAlertStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAlertStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
