// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Catalog information for managed dedicated integration runtime. </summary>
    public partial class IntegrationRuntimeSsisCatalogInfo
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeSsisCatalogInfo. </summary>
        public IntegrationRuntimeSsisCatalogInfo()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeSsisCatalogInfo. </summary>
        /// <param name="catalogServerEndpoint"> The catalog database server URL. </param>
        /// <param name="catalogAdminUserName"> The administrator user name of catalog database. </param>
        /// <param name="catalogAdminPassword"> The password of the administrator user account of the catalog database. </param>
        /// <param name="catalogPricingTier"> The pricing tier for the catalog database. The valid values could be found in https://azure.microsoft.com/en-us/pricing/details/sql-database/. </param>
        /// <param name="dualStandbyPairName"> The dual standby pair name of Azure-SSIS Integration Runtimes to support SSISDB failover. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeSsisCatalogInfo(string catalogServerEndpoint, string catalogAdminUserName, DataFactorySecretString catalogAdminPassword, IntegrationRuntimeSsisCatalogPricingTier? catalogPricingTier, string dualStandbyPairName, IDictionary<string, BinaryData> additionalProperties)
        {
            CatalogServerEndpoint = catalogServerEndpoint;
            CatalogAdminUserName = catalogAdminUserName;
            CatalogAdminPassword = catalogAdminPassword;
            CatalogPricingTier = catalogPricingTier;
            DualStandbyPairName = dualStandbyPairName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The catalog database server URL. </summary>
        public string CatalogServerEndpoint { get; set; }
        /// <summary> The administrator user name of catalog database. </summary>
        public string CatalogAdminUserName { get; set; }
        /// <summary> The password of the administrator user account of the catalog database. </summary>
        public DataFactorySecretString CatalogAdminPassword { get; set; }
        /// <summary> The pricing tier for the catalog database. The valid values could be found in https://azure.microsoft.com/en-us/pricing/details/sql-database/. </summary>
        public IntegrationRuntimeSsisCatalogPricingTier? CatalogPricingTier { get; set; }
        /// <summary> The dual standby pair name of Azure-SSIS Integration Runtimes to support SSISDB failover. </summary>
        public string DualStandbyPairName { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
