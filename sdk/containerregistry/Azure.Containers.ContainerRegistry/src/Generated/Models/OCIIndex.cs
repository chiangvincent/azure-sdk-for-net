// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    /// <summary> Returns the requested OCI index file. </summary>
    internal partial class OciIndex : ImageManifest
    {
        /// <summary> Initializes a new instance of OciIndex. </summary>
        public OciIndex()
        {
            Manifests = new ChangeTrackingList<ManifestListAttributes>();
        }

        /// <summary> Initializes a new instance of OciIndex. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="manifests"> List of OCI image layer information. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        internal OciIndex(int schemaVersion, IList<ManifestListAttributes> manifests, OciManifestAnnotations annotations) : base(schemaVersion)
        {
            Manifests = manifests;
            Annotations = annotations;
        }

        /// <summary> List of OCI image layer information. </summary>
        public IList<ManifestListAttributes> Manifests { get; }
        /// <summary> Additional information provided through arbitrary metadata. </summary>
        public OciManifestAnnotations Annotations { get; set; }
    }
}
