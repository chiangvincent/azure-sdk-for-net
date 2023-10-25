// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Dictionary Example element. </summary>
    public partial class DictionaryExampleItem
    {
        /// <summary> Initializes a new instance of DictionaryExampleItem. </summary>
        /// <param name="normalizedSource">
        /// A string giving the normalized form of the source term. Generally, this should be identical
        /// to the value of the Text field at the matching list index in the body of the request.
        /// </param>
        /// <param name="normalizedTarget">
        /// A string giving the normalized form of the target term. Generally, this should be identical
        /// to the value of the Translation field at the matching list index in the body of the request.
        /// </param>
        /// <param name="examples"> A list of examples for the (source term, target term) pair. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="normalizedSource"/>, <paramref name="normalizedTarget"/> or <paramref name="examples"/> is null. </exception>
        internal DictionaryExampleItem(string normalizedSource, string normalizedTarget, IEnumerable<DictionaryExample> examples)
        {
            Argument.AssertNotNull(normalizedSource, nameof(normalizedSource));
            Argument.AssertNotNull(normalizedTarget, nameof(normalizedTarget));
            Argument.AssertNotNull(examples, nameof(examples));

            NormalizedSource = normalizedSource;
            NormalizedTarget = normalizedTarget;
            Examples = examples.ToList();
        }

        /// <summary> Initializes a new instance of DictionaryExampleItem. </summary>
        /// <param name="normalizedSource">
        /// A string giving the normalized form of the source term. Generally, this should be identical
        /// to the value of the Text field at the matching list index in the body of the request.
        /// </param>
        /// <param name="normalizedTarget">
        /// A string giving the normalized form of the target term. Generally, this should be identical
        /// to the value of the Translation field at the matching list index in the body of the request.
        /// </param>
        /// <param name="examples"> A list of examples for the (source term, target term) pair. </param>
        internal DictionaryExampleItem(string normalizedSource, string normalizedTarget, IReadOnlyList<DictionaryExample> examples)
        {
            NormalizedSource = normalizedSource;
            NormalizedTarget = normalizedTarget;
            Examples = examples;
        }

        /// <summary>
        /// A string giving the normalized form of the source term. Generally, this should be identical
        /// to the value of the Text field at the matching list index in the body of the request.
        /// </summary>
        public string NormalizedSource { get; }
        /// <summary>
        /// A string giving the normalized form of the target term. Generally, this should be identical
        /// to the value of the Translation field at the matching list index in the body of the request.
        /// </summary>
        public string NormalizedTarget { get; }
        /// <summary> A list of examples for the (source term, target term) pair. </summary>
        public IReadOnlyList<DictionaryExample> Examples { get; }
    }
}
