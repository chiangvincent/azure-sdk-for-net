// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> The DocumentFilter. </summary>
    internal partial class DocumentFilter
    {
        /// <summary> Initializes a new instance of DocumentFilter. </summary>
        public DocumentFilter()
        {
        }

        /// <summary>
        /// A case-sensitive prefix string to filter documents in the source path for translation.
        /// For example, when using a Azure storage blob Uri, use the prefix to restrict sub folders for translation.
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// A case-sensitive suffix string to filter documents in the source path for translation.
        /// This is most often use for file extensions
        /// </summary>
        public string Suffix { get; set; }
    }
}
