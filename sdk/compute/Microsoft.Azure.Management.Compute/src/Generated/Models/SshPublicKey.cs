// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about SSH certificate public key and the path on
    /// the Linux VM where the public key is placed.
    /// </summary>
    public partial class SshPublicKey
    {
        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        public SshPublicKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        /// <param name="path">Specifies the full path on the created VM where
        /// ssh public key is stored. If the file already exists, the specified
        /// key is appended to the file. Example:
        /// /home/user/.ssh/authorized_keys</param>
        /// <param name="keyData">SSH public key certificate used to
        /// authenticate with the VM through ssh. The key needs to be at least
        /// 2048-bit and in ssh-rsa format. For creating ssh keys, see [Create
        /// SSH keys on Linux and Mac for Linux VMs in
        /// Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).</param>
        public SshPublicKey(string path = default(string), string keyData = default(string))
        {
            Path = path;
            KeyData = keyData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the full path on the created VM where ssh
        /// public key is stored. If the file already exists, the specified key
        /// is appended to the file. Example: /home/user/.ssh/authorized_keys
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets SSH public key certificate used to authenticate with
        /// the VM through ssh. The key needs to be at least 2048-bit and in
        /// ssh-rsa format. For creating ssh keys, see [Create SSH keys on
        /// Linux and Mac for Linux VMs in
        /// Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
        /// </summary>
        [JsonProperty(PropertyName = "keyData")]
        public string KeyData { get; set; }

    }
}
