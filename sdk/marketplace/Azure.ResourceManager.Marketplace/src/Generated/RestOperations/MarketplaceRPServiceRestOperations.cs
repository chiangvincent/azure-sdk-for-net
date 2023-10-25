// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    internal partial class MarketplaceRPServiceRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of MarketplaceRPServiceRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public MarketplaceRPServiceRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateQueryUserRulesRequest(Guid privateStoreId, QueryUserRulesContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/queryUserRules", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (content != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content0 = new Utf8JsonRequestContent();
                content0.JsonWriter.WriteObjectValue(content);
                request.Content = content0;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> All rules approved in the private store that are relevant for user subscriptions. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="content"> The QueryUserRulesContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<MarketplaceRuleListResult>> QueryUserRulesAsync(Guid privateStoreId, QueryUserRulesContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryUserRulesRequest(privateStoreId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceRuleListResult.DeserializeMarketplaceRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> All rules approved in the private store that are relevant for user subscriptions. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="content"> The QueryUserRulesContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<MarketplaceRuleListResult> QueryUserRules(Guid privateStoreId, QueryUserRulesContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryUserRulesRequest(privateStoreId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceRuleListResult.DeserializeMarketplaceRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSetCollectionRulesRequest(Guid privateStoreId, Guid collectionId, SetRulesContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/setRules", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (content != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content0 = new Utf8JsonRequestContent();
                content0.JsonWriter.WriteObjectValue(content);
                request.Content = content0;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Set rule for specific private store and collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="content"> The SetRulesContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> SetCollectionRulesAsync(Guid privateStoreId, Guid collectionId, SetRulesContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSetCollectionRulesRequest(privateStoreId, collectionId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Set rule for specific private store and collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="content"> The SetRulesContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response SetCollectionRules(Guid privateStoreId, Guid collectionId, SetRulesContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSetCollectionRulesRequest(privateStoreId, collectionId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateQueryRulesRequest(Guid privateStoreId, Guid collectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/queryRules", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a list of all private store rules in the given private store and collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<MarketplaceRuleListResult>> QueryRulesAsync(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryRulesRequest(privateStoreId, collectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceRuleListResult.DeserializeMarketplaceRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of all private store rules in the given private store and collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<MarketplaceRuleListResult> QueryRules(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryRulesRequest(privateStoreId, collectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceRuleListResult.DeserializeMarketplaceRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
