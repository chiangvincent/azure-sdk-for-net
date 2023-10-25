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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevCenterEnvironmentTypeResource" /> and their operations.
    /// Each <see cref="DevCenterEnvironmentTypeResource" /> in the collection will belong to the same instance of <see cref="DevCenterResource" />.
    /// To get a <see cref="DevCenterEnvironmentTypeCollection" /> instance call the GetDevCenterEnvironmentTypes method from an instance of <see cref="DevCenterResource" />.
    /// </summary>
    public partial class DevCenterEnvironmentTypeCollection : ArmCollection, IEnumerable<DevCenterEnvironmentTypeResource>, IAsyncEnumerable<DevCenterEnvironmentTypeResource>
    {
        private readonly ClientDiagnostics _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics;
        private readonly EnvironmentTypesRestOperations _devCenterEnvironmentTypeEnvironmentTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevCenterEnvironmentTypeCollection"/> class for mocking. </summary>
        protected DevCenterEnvironmentTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterEnvironmentTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevCenterEnvironmentTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterEnvironmentTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevCenterEnvironmentTypeResource.ResourceType, out string devCenterEnvironmentTypeEnvironmentTypesApiVersion);
            _devCenterEnvironmentTypeEnvironmentTypesRestClient = new EnvironmentTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterEnvironmentTypeEnvironmentTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="data"> Represents an Environment Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterEnvironmentTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string environmentTypeName, DevCenterEnvironmentTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devCenterEnvironmentTypeEnvironmentTypesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterEnvironmentTypeResource>(Response.FromValue(new DevCenterEnvironmentTypeResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="data"> Represents an Environment Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterEnvironmentTypeResource> CreateOrUpdate(WaitUntil waitUntil, string environmentTypeName, DevCenterEnvironmentTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devCenterEnvironmentTypeEnvironmentTypesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, data, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterEnvironmentTypeResource>(Response.FromValue(new DevCenterEnvironmentTypeResource(Client, response), response.GetRawResponse()));
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
        /// Gets an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<Response<DevCenterEnvironmentTypeResource>> GetAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _devCenterEnvironmentTypeEnvironmentTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual Response<DevCenterEnvironmentTypeResource> Get(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _devCenterEnvironmentTypeEnvironmentTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists environment types for the devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterEnvironmentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterEnvironmentTypeResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterEnvironmentTypeEnvironmentTypesRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterEnvironmentTypeEnvironmentTypesRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevCenterEnvironmentTypeResource(Client, DevCenterEnvironmentTypeData.DeserializeDevCenterEnvironmentTypeData(e)), _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics, Pipeline, "DevCenterEnvironmentTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists environment types for the devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterEnvironmentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterEnvironmentTypeResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterEnvironmentTypeEnvironmentTypesRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterEnvironmentTypeEnvironmentTypesRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevCenterEnvironmentTypeResource(Client, DevCenterEnvironmentTypeData.DeserializeDevCenterEnvironmentTypeData(e)), _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics, Pipeline, "DevCenterEnvironmentTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devCenterEnvironmentTypeEnvironmentTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _devCenterEnvironmentTypeEnvironmentTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<DevCenterEnvironmentTypeResource>> GetIfExistsAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devCenterEnvironmentTypeEnvironmentTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevCenterEnvironmentTypeResource>(response.GetRawResponse());
                return Response.FromValue(new DevCenterEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual NullableResponse<DevCenterEnvironmentTypeResource> GetIfExists(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _devCenterEnvironmentTypeEnvironmentTypesClientDiagnostics.CreateScope("DevCenterEnvironmentTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devCenterEnvironmentTypeEnvironmentTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevCenterEnvironmentTypeResource>(response.GetRawResponse());
                return Response.FromValue(new DevCenterEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevCenterEnvironmentTypeResource> IEnumerable<DevCenterEnvironmentTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevCenterEnvironmentTypeResource> IAsyncEnumerable<DevCenterEnvironmentTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
