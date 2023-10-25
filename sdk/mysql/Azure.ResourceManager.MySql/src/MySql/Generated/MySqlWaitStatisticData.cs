// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing the MySqlWaitStatistic data model.
    /// Represents a Wait Statistic.
    /// </summary>
    public partial class MySqlWaitStatisticData : ResourceData
    {
        /// <summary> Initializes a new instance of MySqlWaitStatisticData. </summary>
        public MySqlWaitStatisticData()
        {
        }

        /// <summary> Initializes a new instance of MySqlWaitStatisticData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Observation start time. </param>
        /// <param name="endOn"> Observation end time. </param>
        /// <param name="eventName"> Wait event name. </param>
        /// <param name="eventTypeName"> Wait event type name. </param>
        /// <param name="queryId"> Database query identifier. </param>
        /// <param name="databaseName"> Database Name. </param>
        /// <param name="userId"> Database user identifier. </param>
        /// <param name="count"> Wait event count observed in this time interval. </param>
        /// <param name="totalTimeInMinutes"> Total time of wait in milliseconds in this time interval. </param>
        internal MySqlWaitStatisticData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? startOn, DateTimeOffset? endOn, string eventName, string eventTypeName, long? queryId, string databaseName, long? userId, long? count, double? totalTimeInMinutes) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            EndOn = endOn;
            EventName = eventName;
            EventTypeName = eventTypeName;
            QueryId = queryId;
            DatabaseName = databaseName;
            UserId = userId;
            Count = count;
            TotalTimeInMinutes = totalTimeInMinutes;
        }

        /// <summary> Observation start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Observation end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Wait event name. </summary>
        public string EventName { get; set; }
        /// <summary> Wait event type name. </summary>
        public string EventTypeName { get; set; }
        /// <summary> Database query identifier. </summary>
        public long? QueryId { get; set; }
        /// <summary> Database Name. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Database user identifier. </summary>
        public long? UserId { get; set; }
        /// <summary> Wait event count observed in this time interval. </summary>
        public long? Count { get; set; }
        /// <summary> Total time of wait in milliseconds in this time interval. </summary>
        public double? TotalTimeInMinutes { get; set; }
    }
}
