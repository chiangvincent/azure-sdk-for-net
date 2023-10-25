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
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SupportTicketFile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SupportTicketFileResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSupportTicketFileResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionFileWorkspaceResource" /> using the GetSupportTicketFile method.
    /// </summary>
    public partial class SupportTicketFileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportTicketFileResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string fileWorkspaceName, string fileName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supportTicketFileFilesClientDiagnostics;
        private readonly FilesRestOperations _supportTicketFileFilesRestClient;
        private readonly SupportFileDetailData _data;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketFileResource"/> class for mocking. </summary>
        protected SupportTicketFileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SupportTicketFileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportTicketFileResource(ArmClient client, SupportFileDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketFileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportTicketFileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketFileFilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supportTicketFileFilesApiVersion);
            _supportTicketFileFilesRestClient = new FilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketFileFilesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/fileWorkspaces/files";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportFileDetailData Data
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
        /// Returns details of a specific file in a work space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportTicketFileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketFileFilesClientDiagnostics.CreateScope("SupportTicketFileResource.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketFileFilesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns details of a specific file in a work space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportTicketFileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketFileFilesClientDiagnostics.CreateScope("SupportTicketFileResource.Get");
            scope.Start();
            try
            {
                var response = _supportTicketFileFilesRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new file under a workspace for the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create file object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupportTicketFileResource>> UpdateAsync(WaitUntil waitUntil, SupportFileDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketFileFilesClientDiagnostics.CreateScope("SupportTicketFileResource.Update");
            scope.Start();
            try
            {
                var response = await _supportTicketFileFilesRestClient.CreateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<SupportTicketFileResource>(Response.FromValue(new SupportTicketFileResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new file under a workspace for the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create file object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupportTicketFileResource> Update(WaitUntil waitUntil, SupportFileDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketFileFilesClientDiagnostics.CreateScope("SupportTicketFileResource.Update");
            scope.Start();
            try
            {
                var response = _supportTicketFileFilesRestClient.Create(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SupportArmOperation<SupportTicketFileResource>(Response.FromValue(new SupportTicketFileResource(Client, response), response.GetRawResponse()));
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
        /// This API allows you to upload content to a file
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}/upload</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Upload</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> UploadFile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response> UploadAsync(UploadFileContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _supportTicketFileFilesClientDiagnostics.CreateScope("SupportTicketFileResource.Upload");
            scope.Start();
            try
            {
                var response = await _supportTicketFileFilesRestClient.UploadAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to upload content to a file
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}/upload</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Upload</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> UploadFile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response Upload(UploadFileContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _supportTicketFileFilesClientDiagnostics.CreateScope("SupportTicketFileResource.Upload");
            scope.Start();
            try
            {
                var response = _supportTicketFileFilesRestClient.Upload(Id.SubscriptionId, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
