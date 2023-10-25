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

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing a collection of <see cref="ElasticSanSnapshotResource" /> and their operations.
    /// Each <see cref="ElasticSanSnapshotResource" /> in the collection will belong to the same instance of <see cref="ElasticSanVolumeGroupResource" />.
    /// To get an <see cref="ElasticSanSnapshotCollection" /> instance call the GetElasticSanSnapshots method from an instance of <see cref="ElasticSanVolumeGroupResource" />.
    /// </summary>
    public partial class ElasticSanSnapshotCollection : ArmCollection, IEnumerable<ElasticSanSnapshotResource>, IAsyncEnumerable<ElasticSanSnapshotResource>
    {
        private readonly ClientDiagnostics _elasticSanSnapshotVolumeSnapshotsClientDiagnostics;
        private readonly VolumeSnapshotsRestOperations _elasticSanSnapshotVolumeSnapshotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticSanSnapshotCollection"/> class for mocking. </summary>
        protected ElasticSanSnapshotCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticSanSnapshotCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticSanSnapshotCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticSanSnapshotVolumeSnapshotsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ElasticSanSnapshotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ElasticSanSnapshotResource.ResourceType, out string elasticSanSnapshotVolumeSnapshotsApiVersion);
            _elasticSanSnapshotVolumeSnapshotsRestClient = new VolumeSnapshotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticSanSnapshotVolumeSnapshotsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ElasticSanVolumeGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ElasticSanVolumeGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Volume Snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="data"> Snapshot object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticSanSnapshotResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string snapshotName, ElasticSanSnapshotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticSanSnapshotVolumeSnapshotsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticSanArmOperation<ElasticSanSnapshotResource>(new ElasticSanSnapshotOperationSource(Client), _elasticSanSnapshotVolumeSnapshotsClientDiagnostics, Pipeline, _elasticSanSnapshotVolumeSnapshotsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Volume Snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="data"> Snapshot object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ElasticSanSnapshotResource> CreateOrUpdate(WaitUntil waitUntil, string snapshotName, ElasticSanSnapshotData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticSanSnapshotVolumeSnapshotsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, data, cancellationToken);
                var operation = new ElasticSanArmOperation<ElasticSanSnapshotResource>(new ElasticSanSnapshotOperationSource(Client), _elasticSanSnapshotVolumeSnapshotsClientDiagnostics, Pipeline, _elasticSanSnapshotVolumeSnapshotsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Volume Snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<Response<ElasticSanSnapshotResource>> GetAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticSanSnapshotVolumeSnapshotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Volume Snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<ElasticSanSnapshotResource> Get(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticSanSnapshotVolumeSnapshotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Snapshots in a VolumeGroup or List Snapshots by Volume (name) in a VolumeGroup using filter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_ListByVolumeGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter='volumeName eq &lt;volume name&gt;' to filter on volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanSnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanSnapshotResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticSanSnapshotVolumeSnapshotsRestClient.CreateListByVolumeGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticSanSnapshotVolumeSnapshotsRestClient.CreateListByVolumeGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticSanSnapshotResource(Client, ElasticSanSnapshotData.DeserializeElasticSanSnapshotData(e)), _elasticSanSnapshotVolumeSnapshotsClientDiagnostics, Pipeline, "ElasticSanSnapshotCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Snapshots in a VolumeGroup or List Snapshots by Volume (name) in a VolumeGroup using filter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_ListByVolumeGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter='volumeName eq &lt;volume name&gt;' to filter on volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanSnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanSnapshotResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticSanSnapshotVolumeSnapshotsRestClient.CreateListByVolumeGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticSanSnapshotVolumeSnapshotsRestClient.CreateListByVolumeGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticSanSnapshotResource(Client, ElasticSanSnapshotData.DeserializeElasticSanSnapshotData(e)), _elasticSanSnapshotVolumeSnapshotsClientDiagnostics, Pipeline, "ElasticSanSnapshotCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.Exists");
            scope.Start();
            try
            {
                var response = await _elasticSanSnapshotVolumeSnapshotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<bool> Exists(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.Exists");
            scope.Start();
            try
            {
                var response = _elasticSanSnapshotVolumeSnapshotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<NullableResponse<ElasticSanSnapshotResource>> GetIfExistsAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _elasticSanSnapshotVolumeSnapshotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ElasticSanSnapshotResource>(response.GetRawResponse());
                return Response.FromValue(new ElasticSanSnapshotResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual NullableResponse<ElasticSanSnapshotResource> GetIfExists(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _elasticSanSnapshotVolumeSnapshotsClientDiagnostics.CreateScope("ElasticSanSnapshotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _elasticSanSnapshotVolumeSnapshotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, snapshotName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ElasticSanSnapshotResource>(response.GetRawResponse());
                return Response.FromValue(new ElasticSanSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticSanSnapshotResource> IEnumerable<ElasticSanSnapshotResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticSanSnapshotResource> IAsyncEnumerable<ElasticSanSnapshotResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
