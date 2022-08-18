// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow output parameter. </summary>
    public partial class LogicWorkflowOutputParameterInfo : LogicWorkflowParameterInfo
    {
        /// <summary> Initializes a new instance of LogicWorkflowOutputParameterInfo. </summary>
        public LogicWorkflowOutputParameterInfo()
        {
        }

        /// <summary> Initializes a new instance of LogicWorkflowOutputParameterInfo. </summary>
        /// <param name="parameterType"> The type. </param>
        /// <param name="value"> The value. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="description"> The description. </param>
        /// <param name="error"> Gets the error. </param>
        internal LogicWorkflowOutputParameterInfo(LogicWorkflowParameterType? parameterType, BinaryData value, BinaryData metadata, string description, BinaryData error) : base(parameterType, value, metadata, description)
        {
            Error = error;
        }

        /// <summary>
        /// Gets the error..
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
        public BinaryData Error { get; }
    }
}
