// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing a collection of <see cref="SapProviderInstanceResource" /> and their operations.
    /// Each <see cref="SapProviderInstanceResource" /> in the collection will belong to the same instance of <see cref="SapMonitorResource" />.
    /// To get a <see cref="SapProviderInstanceCollection" /> instance call the GetSapProviderInstances method from an instance of <see cref="SapMonitorResource" />.
    /// </summary>
    public partial class SapProviderInstanceCollection : ArmCollection, IEnumerable<SapProviderInstanceResource>, IAsyncEnumerable<SapProviderInstanceResource>
    {
        private readonly ClientDiagnostics _sapProviderInstanceProviderInstancesClientDiagnostics;
        private readonly ProviderInstancesRestOperations _sapProviderInstanceProviderInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SapProviderInstanceCollection"/> class for mocking. </summary>
        protected SapProviderInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapProviderInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SapProviderInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapProviderInstanceProviderInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", SapProviderInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SapProviderInstanceResource.ResourceType, out string sapProviderInstanceProviderInstancesApiVersion);
            _sapProviderInstanceProviderInstancesRestClient = new ProviderInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapProviderInstanceProviderInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SapMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SapMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="data"> Request body representing a provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SapProviderInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string providerInstanceName, SapProviderInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<SapProviderInstanceResource>(new SapProviderInstanceOperationSource(Client), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, _sapProviderInstanceProviderInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="data"> Request body representing a provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SapProviderInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string providerInstanceName, SapProviderInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, data, cancellationToken);
                var operation = new WorkloadsArmOperation<SapProviderInstanceResource>(new SapProviderInstanceOperationSource(Client), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, _sapProviderInstanceProviderInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> is null. </exception>
        public virtual async Task<Response<SapProviderInstanceResource>> GetAsync(string providerInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapProviderInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> is null. </exception>
        public virtual Response<SapProviderInstanceResource> Get(string providerInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapProviderInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of provider instances in the specified SAP monitor. The operations returns various properties of each provider instances.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapProviderInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SapProviderInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapProviderInstanceProviderInstancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapProviderInstanceProviderInstancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SapProviderInstanceResource(Client, SapProviderInstanceData.DeserializeSapProviderInstanceData(e)), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, "SapProviderInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of provider instances in the specified SAP monitor. The operations returns various properties of each provider instances.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapProviderInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SapProviderInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapProviderInstanceProviderInstancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapProviderInstanceProviderInstancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SapProviderInstanceResource(Client, SapProviderInstanceData.DeserializeSapProviderInstanceData(e)), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, "SapProviderInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string providerInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SapProviderInstanceResource>> GetIfExistsAsync(string providerInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SapProviderInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new SapProviderInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerInstanceName"> Name of the provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerInstanceName"/> is null. </exception>
        public virtual NullableResponse<SapProviderInstanceResource> GetIfExists(string providerInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerInstanceName, nameof(providerInstanceName));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, providerInstanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SapProviderInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new SapProviderInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SapProviderInstanceResource> IEnumerable<SapProviderInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SapProviderInstanceResource> IAsyncEnumerable<SapProviderInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
