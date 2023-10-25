// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Api key object for workspace connection credential. </summary>
    internal partial class WorkspaceConnectionApiKey
    {
        /// <summary> Initializes a new instance of WorkspaceConnectionApiKey. </summary>
        public WorkspaceConnectionApiKey()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceConnectionApiKey. </summary>
        /// <param name="key"></param>
        internal WorkspaceConnectionApiKey(string key)
        {
            Key = key;
        }

        /// <summary> Gets or sets the key. </summary>
        public string Key { get; set; }
    }
}
