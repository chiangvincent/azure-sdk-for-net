// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Instance view status. </summary>
    [Obsolete("This class is now deprecated. Please use the new class `ArcExtensionInstanceViewStatus` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ExtensionInstanceViewStatus
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtensionInstanceViewStatus"/>. </summary>
        internal ExtensionInstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtensionInstanceViewStatus"/>. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="level"> The level code. </param>
        /// <param name="displayStatus"> The short localizable label for the status. </param>
        /// <param name="message"> The detailed status message, including for alerts and error messages. </param>
        /// <param name="time"> The time of the status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtensionInstanceViewStatus(string code, HciStatusLevelType? level, string displayStatus, string message, DateTimeOffset? time, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status code. </summary>
        public string Code { get; }
        /// <summary> The level code. </summary>
        public HciStatusLevelType? Level { get; }
        /// <summary> The short localizable label for the status. </summary>
        public string DisplayStatus { get; }
        /// <summary> The detailed status message, including for alerts and error messages. </summary>
        public string Message { get; }
        /// <summary> The time of the status. </summary>
        public DateTimeOffset? Time { get; }
    }
}
