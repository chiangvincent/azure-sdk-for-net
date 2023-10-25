// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal class BackupPrivateEndpointConnectionOperationSource : IOperationSource<BackupPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal BackupPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        BackupPrivateEndpointConnectionResource IOperationSource<BackupPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BackupPrivateEndpointConnectionData.DeserializeBackupPrivateEndpointConnectionData(document.RootElement);
            return new BackupPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<BackupPrivateEndpointConnectionResource> IOperationSource<BackupPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BackupPrivateEndpointConnectionData.DeserializeBackupPrivateEndpointConnectionData(document.RootElement);
            return new BackupPrivateEndpointConnectionResource(_client, data);
        }
    }
}
