// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automanage.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing the AutomanageConfigurationProfile data model.
    /// Definition of the configuration profile.
    /// </summary>
    public partial class AutomanageConfigurationProfileData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AutomanageConfigurationProfileData. </summary>
        /// <param name="location"> The location. </param>
        public AutomanageConfigurationProfileData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AutomanageConfigurationProfileData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of the configuration profile. </param>
        internal AutomanageConfigurationProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ConfigurationProfileProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> Properties of the configuration profile. </summary>
        internal ConfigurationProfileProperties Properties { get; set; }
        /// <summary>
        /// configuration dictionary of the configuration profile.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Configuration
        {
            get => Properties is null ? default : Properties.Configuration;
            set
            {
                if (Properties is null)
                    Properties = new ConfigurationProfileProperties();
                Properties.Configuration = value;
            }
        }
    }
}
