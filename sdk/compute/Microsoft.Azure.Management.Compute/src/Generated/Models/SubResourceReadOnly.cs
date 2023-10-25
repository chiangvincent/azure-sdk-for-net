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

    public partial class SubResourceReadOnly
    {
        /// <summary>
        /// Initializes a new instance of the SubResourceReadOnly class.
        /// </summary>
        public SubResourceReadOnly()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubResourceReadOnly class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        public SubResourceReadOnly(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
