// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount option is selected in case of missing input.
    /// Please note <see cref="FileShareConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CreateAndMountFileShareConfiguration"/>, <see cref="MountFileShareConfiguration"/> and <see cref="SkipFileShareConfiguration"/>.
    /// </summary>
    public abstract partial class FileShareConfiguration
    {
        /// <summary> Initializes a new instance of FileShareConfiguration. </summary>
        protected FileShareConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FileShareConfiguration. </summary>
        /// <param name="configurationType"> The type of file share config. </param>
        internal FileShareConfiguration(ConfigurationType configurationType)
        {
            ConfigurationType = configurationType;
        }

        /// <summary> The type of file share config. </summary>
        internal ConfigurationType ConfigurationType { get; set; }
    }
}
