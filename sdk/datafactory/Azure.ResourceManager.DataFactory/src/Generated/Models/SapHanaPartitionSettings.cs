// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The settings that will be leveraged for SAP HANA source partitioning. </summary>
    internal partial class SapHanaPartitionSettings
    {
        /// <summary> Initializes a new instance of SapHanaPartitionSettings. </summary>
        public SapHanaPartitionSettings()
        {
        }

        /// <summary> Initializes a new instance of SapHanaPartitionSettings. </summary>
        /// <param name="partitionColumnName"> The name of the column that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        internal SapHanaPartitionSettings(BinaryData partitionColumnName)
        {
            PartitionColumnName = partitionColumnName;
        }

        /// <summary>
        /// The name of the column that will be used for proceeding range partitioning. Type: string (or Expression with resultType string)..
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
        public BinaryData PartitionColumnName { get; set; }
    }
}
