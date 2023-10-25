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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="DefaultRolloutResource" /> and their operations.
    /// Each <see cref="DefaultRolloutResource" /> in the collection will belong to the same instance of <see cref="ProviderRegistrationResource" />.
    /// To get a <see cref="DefaultRolloutCollection" /> instance call the GetDefaultRollouts method from an instance of <see cref="ProviderRegistrationResource" />.
    /// </summary>
    public partial class DefaultRolloutCollection : ArmCollection, IEnumerable<DefaultRolloutResource>, IAsyncEnumerable<DefaultRolloutResource>
    {
        private readonly ClientDiagnostics _defaultRolloutClientDiagnostics;
        private readonly DefaultRolloutsRestOperations _defaultRolloutRestClient;

        /// <summary> Initializes a new instance of the <see cref="DefaultRolloutCollection"/> class for mocking. </summary>
        protected DefaultRolloutCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DefaultRolloutCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DefaultRolloutCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _defaultRolloutClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", DefaultRolloutResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DefaultRolloutResource.ResourceType, out string defaultRolloutApiVersion);
            _defaultRolloutRestClient = new DefaultRolloutsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, defaultRolloutApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProviderRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProviderRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="data"> The Default rollout properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DefaultRolloutResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string rolloutName, DefaultRolloutData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _defaultRolloutRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, rolloutName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<DefaultRolloutResource>(new DefaultRolloutOperationSource(Client), _defaultRolloutClientDiagnostics, Pipeline, _defaultRolloutRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Name, rolloutName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="data"> The Default rollout properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DefaultRolloutResource> CreateOrUpdate(WaitUntil waitUntil, string rolloutName, DefaultRolloutData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _defaultRolloutRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, rolloutName, data, cancellationToken);
                var operation = new ProviderHubArmOperation<DefaultRolloutResource>(new DefaultRolloutOperationSource(Client), _defaultRolloutClientDiagnostics, Pipeline, _defaultRolloutRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Name, rolloutName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the default rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<Response<DefaultRolloutResource>> GetAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.Get");
            scope.Start();
            try
            {
                var response = await _defaultRolloutRestClient.GetAsync(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefaultRolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the default rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual Response<DefaultRolloutResource> Get(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.Get");
            scope.Start();
            try
            {
                var response = _defaultRolloutRestClient.Get(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefaultRolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of the rollouts for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_ListByProviderRegistration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DefaultRolloutResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DefaultRolloutResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _defaultRolloutRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _defaultRolloutRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DefaultRolloutResource(Client, DefaultRolloutData.DeserializeDefaultRolloutData(e)), _defaultRolloutClientDiagnostics, Pipeline, "DefaultRolloutCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of the rollouts for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_ListByProviderRegistration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DefaultRolloutResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DefaultRolloutResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _defaultRolloutRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _defaultRolloutRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DefaultRolloutResource(Client, DefaultRolloutData.DeserializeDefaultRolloutData(e)), _defaultRolloutClientDiagnostics, Pipeline, "DefaultRolloutCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.Exists");
            scope.Start();
            try
            {
                var response = await _defaultRolloutRestClient.GetAsync(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual Response<bool> Exists(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.Exists");
            scope.Start();
            try
            {
                var response = _defaultRolloutRestClient.Get(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<NullableResponse<DefaultRolloutResource>> GetIfExistsAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _defaultRolloutRestClient.GetAsync(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DefaultRolloutResource>(response.GetRawResponse());
                return Response.FromValue(new DefaultRolloutResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual NullableResponse<DefaultRolloutResource> GetIfExists(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _defaultRolloutClientDiagnostics.CreateScope("DefaultRolloutCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _defaultRolloutRestClient.Get(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DefaultRolloutResource>(response.GetRawResponse());
                return Response.FromValue(new DefaultRolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DefaultRolloutResource> IEnumerable<DefaultRolloutResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DefaultRolloutResource> IAsyncEnumerable<DefaultRolloutResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
