// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a SubscriptionNetworkManagerConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SubscriptionNetworkManagerConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSubscriptionNetworkManagerConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetSubscriptionNetworkManagerConnection method.
    /// </summary>
    public partial class SubscriptionNetworkManagerConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionNetworkManagerConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string networkManagerConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionNetworkManagerConnectionClientDiagnostics;
        private readonly SubscriptionNetworkManagerConnectionsRestOperations _subscriptionNetworkManagerConnectionRestClient;
        private readonly NetworkManagerConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionNetworkManagerConnectionResource"/> class for mocking. </summary>
        protected SubscriptionNetworkManagerConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionNetworkManagerConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionNetworkManagerConnectionResource(ArmClient client, NetworkManagerConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionNetworkManagerConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionNetworkManagerConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionNetworkManagerConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionNetworkManagerConnectionApiVersion);
            _subscriptionNetworkManagerConnectionRestClient = new SubscriptionNetworkManagerConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionNetworkManagerConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkManagerConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkManagerConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a specified connection created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionNetworkManagerConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specified connection created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionNetworkManagerConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete specified connection created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete specified connection created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a network manager connection on this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Network manager connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionNetworkManagerConnectionResource>> UpdateAsync(WaitUntil waitUntil, NetworkManagerConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<SubscriptionNetworkManagerConnectionResource>(Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Create a network manager connection on this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Network manager connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionNetworkManagerConnectionResource> Update(WaitUntil waitUntil, NetworkManagerConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<SubscriptionNetworkManagerConnectionResource>(Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response), response.GetRawResponse()));
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
    }
}
