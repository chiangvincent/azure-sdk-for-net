// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class representing the IntegrationAccountSchema data model. </summary>
    public partial class IntegrationAccountSchemaData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationAccountSchemaData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="schemaType"> The schema type. </param>
        public IntegrationAccountSchemaData(AzureLocation location, IntegrationAccountSchemaType schemaType) : base(location)
        {
            SchemaType = schemaType;
        }

        /// <summary> Initializes a new instance of IntegrationAccountSchemaData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="schemaType"> The schema type. </param>
        /// <param name="targetNamespace"> The target namespace of the schema. </param>
        /// <param name="documentName"> The document name. </param>
        /// <param name="fileName"> The file name. </param>
        /// <param name="createdOn"> The created time. </param>
        /// <param name="changedOn"> The changed time. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="content"> The content. </param>
        /// <param name="contentType"> The content type. </param>
        /// <param name="contentLink"> The content link. </param>
        internal IntegrationAccountSchemaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IntegrationAccountSchemaType schemaType, string targetNamespace, string documentName, string fileName, DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, BinaryData content, ContentType? contentType, LogicContentLink contentLink) : base(id, name, resourceType, systemData, tags, location)
        {
            SchemaType = schemaType;
            TargetNamespace = targetNamespace;
            DocumentName = documentName;
            FileName = fileName;
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            Metadata = metadata;
            Content = content;
            ContentType = contentType;
            ContentLink = contentLink;
        }

        /// <summary> The schema type. </summary>
        public IntegrationAccountSchemaType SchemaType { get; set; }
        /// <summary> The target namespace of the schema. </summary>
        public string TargetNamespace { get; set; }
        /// <summary> The document name. </summary>
        public string DocumentName { get; set; }
        /// <summary> The file name. </summary>
        public string FileName { get; set; }
        /// <summary> The created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The changed time. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary>
        /// The metadata..
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
        public BinaryData Metadata { get; set; }
        /// <summary>
        /// The content..
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
        public BinaryData Content { get; set; }
        /// <summary> The content type. </summary>
        public ContentType? ContentType { get; set; }
        /// <summary> The content link. </summary>
        public LogicContentLink ContentLink { get; }
    }
}
