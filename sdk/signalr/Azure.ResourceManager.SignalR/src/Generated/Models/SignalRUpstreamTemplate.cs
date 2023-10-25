// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary>
    /// Upstream template item settings. It defines the Upstream URL of the incoming requests.
    /// The template defines the pattern of the event, the hub or the category of the incoming request that matches current URL template.
    /// </summary>
    public partial class SignalRUpstreamTemplate
    {
        /// <summary> Initializes a new instance of SignalRUpstreamTemplate. </summary>
        /// <param name="urlTemplate">
        /// Gets or sets the Upstream URL template. You can use 3 predefined parameters {hub}, {category} {event} inside the template, the value of the Upstream URL is dynamically calculated when the client request comes in.
        /// For example, if the urlTemplate is `http://example.com/{hub}/api/{event}`, with a client request from hub `chat` connects, it will first POST to this URL: `http://example.com/chat/api/connect`.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="urlTemplate"/> is null. </exception>
        public SignalRUpstreamTemplate(string urlTemplate)
        {
            Argument.AssertNotNull(urlTemplate, nameof(urlTemplate));

            UrlTemplate = urlTemplate;
        }

        /// <summary> Initializes a new instance of SignalRUpstreamTemplate. </summary>
        /// <param name="hubPattern">
        /// Gets or sets the matching pattern for hub names. If not set, it matches any hub.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any hub name.
        ///     2. Combine multiple hubs with ",", for example "hub1,hub2", it matches "hub1" and "hub2".
        ///     3. The single hub name, for example, "hub1", it matches "hub1".
        /// </param>
        /// <param name="eventPattern">
        /// Gets or sets the matching pattern for event names. If not set, it matches any event.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any event name.
        ///     2. Combine multiple events with ",", for example "connect,disconnect", it matches event "connect" and "disconnect".
        ///     3. The single event name, for example, "connect", it matches "connect".
        /// </param>
        /// <param name="categoryPattern">
        /// Gets or sets the matching pattern for category names. If not set, it matches any category.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any category name.
        ///     2. Combine multiple categories with ",", for example "connections,messages", it matches category "connections" and "messages".
        ///     3. The single category name, for example, "connections", it matches the category "connections".
        /// </param>
        /// <param name="urlTemplate">
        /// Gets or sets the Upstream URL template. You can use 3 predefined parameters {hub}, {category} {event} inside the template, the value of the Upstream URL is dynamically calculated when the client request comes in.
        /// For example, if the urlTemplate is `http://example.com/{hub}/api/{event}`, with a client request from hub `chat` connects, it will first POST to this URL: `http://example.com/chat/api/connect`.
        /// </param>
        /// <param name="auth"> Upstream auth settings. If not set, no auth is used for upstream messages. </param>
        internal SignalRUpstreamTemplate(string hubPattern, string eventPattern, string categoryPattern, string urlTemplate, SignalRUpstreamAuthSettings auth)
        {
            HubPattern = hubPattern;
            EventPattern = eventPattern;
            CategoryPattern = categoryPattern;
            UrlTemplate = urlTemplate;
            Auth = auth;
        }

        /// <summary>
        /// Gets or sets the matching pattern for hub names. If not set, it matches any hub.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any hub name.
        ///     2. Combine multiple hubs with ",", for example "hub1,hub2", it matches "hub1" and "hub2".
        ///     3. The single hub name, for example, "hub1", it matches "hub1".
        /// </summary>
        public string HubPattern { get; set; }
        /// <summary>
        /// Gets or sets the matching pattern for event names. If not set, it matches any event.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any event name.
        ///     2. Combine multiple events with ",", for example "connect,disconnect", it matches event "connect" and "disconnect".
        ///     3. The single event name, for example, "connect", it matches "connect".
        /// </summary>
        public string EventPattern { get; set; }
        /// <summary>
        /// Gets or sets the matching pattern for category names. If not set, it matches any category.
        /// There are 3 kind of patterns supported:
        ///     1. "*", it to matches any category name.
        ///     2. Combine multiple categories with ",", for example "connections,messages", it matches category "connections" and "messages".
        ///     3. The single category name, for example, "connections", it matches the category "connections".
        /// </summary>
        public string CategoryPattern { get; set; }
        /// <summary>
        /// Gets or sets the Upstream URL template. You can use 3 predefined parameters {hub}, {category} {event} inside the template, the value of the Upstream URL is dynamically calculated when the client request comes in.
        /// For example, if the urlTemplate is `http://example.com/{hub}/api/{event}`, with a client request from hub `chat` connects, it will first POST to this URL: `http://example.com/chat/api/connect`.
        /// </summary>
        public string UrlTemplate { get; set; }
        /// <summary> Upstream auth settings. If not set, no auth is used for upstream messages. </summary>
        public SignalRUpstreamAuthSettings Auth { get; set; }
    }
}
