// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Hci
{
    internal class HciClusterSecuritySettingOperationSource : IOperationSource<HciClusterSecuritySettingResource>
    {
        private readonly ArmClient _client;

        internal HciClusterSecuritySettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        HciClusterSecuritySettingResource IOperationSource<HciClusterSecuritySettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HciClusterSecuritySettingData.DeserializeHciClusterSecuritySettingData(document.RootElement);
            return new HciClusterSecuritySettingResource(_client, data);
        }

        async ValueTask<HciClusterSecuritySettingResource> IOperationSource<HciClusterSecuritySettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HciClusterSecuritySettingData.DeserializeHciClusterSecuritySettingData(document.RootElement);
            return new HciClusterSecuritySettingResource(_client, data);
        }
    }
}
