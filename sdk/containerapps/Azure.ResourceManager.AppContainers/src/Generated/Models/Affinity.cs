// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Sticky Session Affinity. </summary>
    public readonly partial struct Affinity : IEquatable<Affinity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Affinity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Affinity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StickyValue = "sticky";
        private const string NoneValue = "none";

        /// <summary> sticky. </summary>
        public static Affinity Sticky { get; } = new Affinity(StickyValue);
        /// <summary> none. </summary>
        public static Affinity None { get; } = new Affinity(NoneValue);
        /// <summary> Determines if two <see cref="Affinity"/> values are the same. </summary>
        public static bool operator ==(Affinity left, Affinity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Affinity"/> values are not the same. </summary>
        public static bool operator !=(Affinity left, Affinity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Affinity"/>. </summary>
        public static implicit operator Affinity(string value) => new Affinity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Affinity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Affinity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
