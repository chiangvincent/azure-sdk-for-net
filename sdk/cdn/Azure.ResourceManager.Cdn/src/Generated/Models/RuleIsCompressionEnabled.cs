// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Indicates whether content compression is enabled. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB. </summary>
    public readonly partial struct RuleIsCompressionEnabled : IEquatable<RuleIsCompressionEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RuleIsCompressionEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RuleIsCompressionEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static RuleIsCompressionEnabled Enabled { get; } = new RuleIsCompressionEnabled(EnabledValue);
        /// <summary> Disabled. </summary>
        public static RuleIsCompressionEnabled Disabled { get; } = new RuleIsCompressionEnabled(DisabledValue);
        /// <summary> Determines if two <see cref="RuleIsCompressionEnabled"/> values are the same. </summary>
        public static bool operator ==(RuleIsCompressionEnabled left, RuleIsCompressionEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RuleIsCompressionEnabled"/> values are not the same. </summary>
        public static bool operator !=(RuleIsCompressionEnabled left, RuleIsCompressionEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RuleIsCompressionEnabled"/>. </summary>
        public static implicit operator RuleIsCompressionEnabled(string value) => new RuleIsCompressionEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RuleIsCompressionEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RuleIsCompressionEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
