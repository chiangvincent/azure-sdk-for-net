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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudL3NetworkResource" /> and their operations.
    /// Each <see cref="NetworkCloudL3NetworkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkCloudL3NetworkCollection" /> instance call the GetNetworkCloudL3Networks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkCloudL3NetworkCollection : ArmCollection, IEnumerable<NetworkCloudL3NetworkResource>, IAsyncEnumerable<NetworkCloudL3NetworkResource>
    {
        private readonly ClientDiagnostics _networkCloudL3NetworkL3NetworksClientDiagnostics;
        private readonly L3NetworksRestOperations _networkCloudL3NetworkL3NetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudL3NetworkCollection"/> class for mocking. </summary>
        protected NetworkCloudL3NetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudL3NetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudL3NetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudL3NetworkL3NetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudL3NetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudL3NetworkResource.ResourceType, out string networkCloudL3NetworkL3NetworksApiVersion);
            _networkCloudL3NetworkL3NetworksRestClient = new L3NetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudL3NetworkL3NetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new layer 3 (L3) network or update the properties of the existing network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudL3NetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string l3NetworkName, NetworkCloudL3NetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudL3NetworkL3NetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudL3NetworkResource>(new NetworkCloudL3NetworkOperationSource(Client), _networkCloudL3NetworkL3NetworksClientDiagnostics, Pipeline, _networkCloudL3NetworkL3NetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new layer 3 (L3) network or update the properties of the existing network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudL3NetworkResource> CreateOrUpdate(WaitUntil waitUntil, string l3NetworkName, NetworkCloudL3NetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudL3NetworkL3NetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudL3NetworkResource>(new NetworkCloudL3NetworkOperationSource(Client), _networkCloudL3NetworkL3NetworksClientDiagnostics, Pipeline, _networkCloudL3NetworkL3NetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of the provided layer 3 (L3) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudL3NetworkResource>> GetAsync(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudL3NetworkL3NetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudL3NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided layer 3 (L3) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        public virtual Response<NetworkCloudL3NetworkResource> Get(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudL3NetworkL3NetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudL3NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of layer 3 (L3) networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudL3NetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudL3NetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudL3NetworkL3NetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudL3NetworkL3NetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudL3NetworkResource(Client, NetworkCloudL3NetworkData.DeserializeNetworkCloudL3NetworkData(e)), _networkCloudL3NetworkL3NetworksClientDiagnostics, Pipeline, "NetworkCloudL3NetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of layer 3 (L3) networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudL3NetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudL3NetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudL3NetworkL3NetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudL3NetworkL3NetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudL3NetworkResource(Client, NetworkCloudL3NetworkData.DeserializeNetworkCloudL3NetworkData(e)), _networkCloudL3NetworkL3NetworksClientDiagnostics, Pipeline, "NetworkCloudL3NetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudL3NetworkL3NetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudL3NetworkL3NetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudL3NetworkResource>> GetIfExistsAsync(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudL3NetworkL3NetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudL3NetworkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudL3NetworkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l3Networks/{l3NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3NetworkName"> The name of the L3 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3NetworkName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudL3NetworkResource> GetIfExists(string l3NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3NetworkName, nameof(l3NetworkName));

            using var scope = _networkCloudL3NetworkL3NetworksClientDiagnostics.CreateScope("NetworkCloudL3NetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudL3NetworkL3NetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l3NetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudL3NetworkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudL3NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudL3NetworkResource> IEnumerable<NetworkCloudL3NetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudL3NetworkResource> IAsyncEnumerable<NetworkCloudL3NetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
