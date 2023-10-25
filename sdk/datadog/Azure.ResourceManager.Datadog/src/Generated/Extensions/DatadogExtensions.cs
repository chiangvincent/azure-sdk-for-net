// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Datadog.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Datadog
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Datadog. </summary>
    public static partial class DatadogExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region DatadogMonitorResource
        /// <summary>
        /// Gets an object representing a <see cref="DatadogMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DatadogMonitorResource.CreateResourceIdentifier" /> to create a <see cref="DatadogMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatadogMonitorResource" /> object. </returns>
        public static DatadogMonitorResource GetDatadogMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DatadogMonitorResource.ValidateResourceId(id);
                return new DatadogMonitorResource(client, id);
            }
            );
        }
        #endregion

        #region MonitoringTagRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="MonitoringTagRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MonitoringTagRuleResource.CreateResourceIdentifier" /> to create a <see cref="MonitoringTagRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MonitoringTagRuleResource" /> object. </returns>
        public static MonitoringTagRuleResource GetMonitoringTagRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MonitoringTagRuleResource.ValidateResourceId(id);
                return new MonitoringTagRuleResource(client, id);
            }
            );
        }
        #endregion

        #region DatadogSingleSignOnResource
        /// <summary>
        /// Gets an object representing a <see cref="DatadogSingleSignOnResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DatadogSingleSignOnResource.CreateResourceIdentifier" /> to create a <see cref="DatadogSingleSignOnResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatadogSingleSignOnResource" /> object. </returns>
        public static DatadogSingleSignOnResource GetDatadogSingleSignOnResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DatadogSingleSignOnResource.ValidateResourceId(id);
                return new DatadogSingleSignOnResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of DatadogMonitorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DatadogMonitorResources and their operations over a DatadogMonitorResource. </returns>
        public static DatadogMonitorResourceCollection GetDatadogMonitorResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetDatadogMonitorResources();
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DatadogMonitorResource>> GetDatadogMonitorResourceAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDatadogMonitorResources().GetAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DatadogMonitorResource> GetDatadogMonitorResource(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDatadogMonitorResources().Get(monitorName, cancellationToken);
        }

        /// <summary>
        /// List Datadog marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatadogAgreementResourceProperties" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DatadogAgreementResourceProperties> GetMarketplaceAgreementsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetMarketplaceAgreementsAsync(cancellationToken);
        }

        /// <summary>
        /// List Datadog marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatadogAgreementResourceProperties" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DatadogAgreementResourceProperties> GetMarketplaceAgreements(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetMarketplaceAgreements(cancellationToken);
        }

        /// <summary>
        /// Create Datadog marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> The DatadogAgreementResourceProperties to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<DatadogAgreementResourceProperties>> CreateOrUpdateMarketplaceAgreementAsync(this SubscriptionResource subscriptionResource, DatadogAgreementResourceProperties body = null, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionResourceExtensionClient(subscriptionResource).CreateOrUpdateMarketplaceAgreementAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create Datadog marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> The DatadogAgreementResourceProperties to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<DatadogAgreementResourceProperties> CreateOrUpdateMarketplaceAgreement(this SubscriptionResource subscriptionResource, DatadogAgreementResourceProperties body = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).CreateOrUpdateMarketplaceAgreement(body, cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatadogMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DatadogMonitorResource> GetDatadogMonitorResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetDatadogMonitorResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Datadog/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatadogMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DatadogMonitorResource> GetDatadogMonitorResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetDatadogMonitorResources(cancellationToken);
        }
    }
}
