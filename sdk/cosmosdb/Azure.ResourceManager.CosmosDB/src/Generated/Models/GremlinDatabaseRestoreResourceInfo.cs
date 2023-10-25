// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Specific Gremlin Databases to restore. </summary>
    public partial class GremlinDatabaseRestoreResourceInfo
    {
        /// <summary> Initializes a new instance of GremlinDatabaseRestoreResourceInfo. </summary>
        public GremlinDatabaseRestoreResourceInfo()
        {
            GraphNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GremlinDatabaseRestoreResourceInfo. </summary>
        /// <param name="databaseName"> The name of the gremlin database available for restore. </param>
        /// <param name="graphNames"> The names of the graphs available for restore. </param>
        internal GremlinDatabaseRestoreResourceInfo(string databaseName, IList<string> graphNames)
        {
            DatabaseName = databaseName;
            GraphNames = graphNames;
        }

        /// <summary> The name of the gremlin database available for restore. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The names of the graphs available for restore. </summary>
        public IList<string> GraphNames { get; }
    }
}
