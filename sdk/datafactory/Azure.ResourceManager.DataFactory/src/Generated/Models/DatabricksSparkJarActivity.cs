// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> DatabricksSparkJar activity. </summary>
    public partial class DatabricksSparkJarActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DatabricksSparkJarActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="mainClassName"> The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="mainClassName"/> is null. </exception>
        public DatabricksSparkJarActivity(string name, BinaryData mainClassName) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (mainClassName == null)
            {
                throw new ArgumentNullException(nameof(mainClassName));
            }

            MainClassName = mainClassName;
            Parameters = new ChangeTrackingList<BinaryData>();
            Libraries = new ChangeTrackingList<IDictionary<string, BinaryData>>();
            ActivityType = "DatabricksSparkJar";
        }

        /// <summary> Initializes a new instance of DatabricksSparkJarActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="mainClassName"> The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string). </param>
        /// <param name="parameters"> Parameters that will be passed to the main method. </param>
        /// <param name="libraries"> A list of libraries to be installed on the cluster that will execute the job. </param>
        internal DatabricksSparkJarActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData mainClassName, IList<BinaryData> parameters, IList<IDictionary<string, BinaryData>> libraries) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            MainClassName = mainClassName;
            Parameters = parameters;
            Libraries = libraries;
            ActivityType = activityType ?? "DatabricksSparkJar";
        }

        /// <summary>
        /// The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string)..
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
        public BinaryData MainClassName { get; set; }
        /// <summary> Parameters that will be passed to the main method. </summary>
        public IList<BinaryData> Parameters { get; }
        /// <summary> A list of libraries to be installed on the cluster that will execute the job. </summary>
        public IList<IDictionary<string, BinaryData>> Libraries { get; }
    }
}
