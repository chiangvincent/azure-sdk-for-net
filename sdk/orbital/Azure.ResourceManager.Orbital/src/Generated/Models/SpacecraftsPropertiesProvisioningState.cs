// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> The current state of the resource&apos;s creation, deletion, or modification. </summary>
    public readonly partial struct SpacecraftsPropertiesProvisioningState : IEquatable<SpacecraftsPropertiesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpacecraftsPropertiesProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpacecraftsPropertiesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static SpacecraftsPropertiesProvisioningState Creating { get; } = new SpacecraftsPropertiesProvisioningState(CreatingValue);
        /// <summary> Succeeded. </summary>
        public static SpacecraftsPropertiesProvisioningState Succeeded { get; } = new SpacecraftsPropertiesProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static SpacecraftsPropertiesProvisioningState Failed { get; } = new SpacecraftsPropertiesProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static SpacecraftsPropertiesProvisioningState Canceled { get; } = new SpacecraftsPropertiesProvisioningState(CanceledValue);
        /// <summary> Updating. </summary>
        public static SpacecraftsPropertiesProvisioningState Updating { get; } = new SpacecraftsPropertiesProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static SpacecraftsPropertiesProvisioningState Deleting { get; } = new SpacecraftsPropertiesProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="SpacecraftsPropertiesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SpacecraftsPropertiesProvisioningState left, SpacecraftsPropertiesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpacecraftsPropertiesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SpacecraftsPropertiesProvisioningState left, SpacecraftsPropertiesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SpacecraftsPropertiesProvisioningState"/>. </summary>
        public static implicit operator SpacecraftsPropertiesProvisioningState(string value) => new SpacecraftsPropertiesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpacecraftsPropertiesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpacecraftsPropertiesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
