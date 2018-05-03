// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Check Name Availability for Namespace and
    /// NotificationHubs.
    /// </summary>
    public partial class CheckNameAvailabilityRequestParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckNameAvailabilityRequestParameters class.
        /// </summary>
        public CheckNameAvailabilityRequestParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckNameAvailabilityRequestParameters class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        public CheckNameAvailabilityRequestParameters(string name, string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource name
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
