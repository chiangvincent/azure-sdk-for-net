// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Personalizer
{
    internal partial class EventsRestClient
    {
        private string endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of EventsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public EventsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateRewardRequest(string eventId, PersonalizerRewardOptions reward)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/personalizer/v1.1-preview.3", false);
            uri.AppendPath("/events/", false);
            uri.AppendPath(eventId, true);
            uri.AppendPath("/reward", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(reward);
            request.Content = content;
            return message;
        }

        /// <summary> Report reward between 0 and 1 that resulted from using the action specified in rewardActionId, for the specified event. </summary>
        /// <param name="eventId"> The event id this reward applies to. </param>
        /// <param name="reward"> The reward should be a floating point number, typically between 0 and 1. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventId"/> or <paramref name="reward"/> is null. </exception>
        public async Task<Response> RewardAsync(string eventId, PersonalizerRewardOptions reward, CancellationToken cancellationToken = default)
        {
            if (eventId == null)
            {
                throw new ArgumentNullException(nameof(eventId));
            }
            if (reward == null)
            {
                throw new ArgumentNullException(nameof(reward));
            }

            using var message = CreateRewardRequest(eventId, reward);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Report reward between 0 and 1 that resulted from using the action specified in rewardActionId, for the specified event. </summary>
        /// <param name="eventId"> The event id this reward applies to. </param>
        /// <param name="reward"> The reward should be a floating point number, typically between 0 and 1. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventId"/> or <paramref name="reward"/> is null. </exception>
        public Response Reward(string eventId, PersonalizerRewardOptions reward, CancellationToken cancellationToken = default)
        {
            if (eventId == null)
            {
                throw new ArgumentNullException(nameof(eventId));
            }
            if (reward == null)
            {
                throw new ArgumentNullException(nameof(reward));
            }

            using var message = CreateRewardRequest(eventId, reward);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateActivateRequest(string eventId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/personalizer/v1.1-preview.3", false);
            uri.AppendPath("/events/", false);
            uri.AppendPath(eventId, true);
            uri.AppendPath("/activate", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Report that the specified event was actually used (e.g. by being displayed to the user) and a reward should be expected for it. </summary>
        /// <param name="eventId"> The event ID to be activated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventId"/> is null. </exception>
        public async Task<Response> ActivateAsync(string eventId, CancellationToken cancellationToken = default)
        {
            if (eventId == null)
            {
                throw new ArgumentNullException(nameof(eventId));
            }

            using var message = CreateActivateRequest(eventId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Report that the specified event was actually used (e.g. by being displayed to the user) and a reward should be expected for it. </summary>
        /// <param name="eventId"> The event ID to be activated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventId"/> is null. </exception>
        public Response Activate(string eventId, CancellationToken cancellationToken = default)
        {
            if (eventId == null)
            {
                throw new ArgumentNullException(nameof(eventId));
            }

            using var message = CreateActivateRequest(eventId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
