// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The list of bot service connection settings response. </summary>
    internal partial class ConnectionSettingResponseList
    {
        /// <summary> Initializes a new instance of ConnectionSettingResponseList. </summary>
        internal ConnectionSettingResponseList()
        {
            Value = new ChangeTrackingList<BotConnectionSettingData>();
        }

        /// <summary> Initializes a new instance of ConnectionSettingResponseList. </summary>
        /// <param name="nextLink"> The link used to get the next page of bot service connection setting resources. </param>
        /// <param name="value"> Gets the list of bot service connection settings and their properties. </param>
        internal ConnectionSettingResponseList(string nextLink, IReadOnlyList<BotConnectionSettingData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of bot service connection setting resources. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of bot service connection settings and their properties. </summary>
        public IReadOnlyList<BotConnectionSettingData> Value { get; }
    }
}
