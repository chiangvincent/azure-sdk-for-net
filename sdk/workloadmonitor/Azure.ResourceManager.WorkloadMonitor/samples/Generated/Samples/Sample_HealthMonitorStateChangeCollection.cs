// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.WorkloadMonitor;

namespace Azure.ResourceManager.WorkloadMonitor.Samples
{
    public partial class Sample_HealthMonitorStateChangeCollection
    {
        // Get monitor state changes with default values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetMonitorStateChangesWithDefaultValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorHistory_GetDefault.json
            // this example is just showing the usage of "HealthMonitors_ListStateChanges" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation and iterate over the result
            DateTimeOffset? startTimestampUtc = DateTimeOffset.Parse("2020-10-19T19:24:14Z");
            DateTimeOffset? endTimestampUtc = DateTimeOffset.Parse("2020-10-20T01:24:14Z");
            await foreach (HealthMonitorStateChangeResource item in collection.GetAllAsync(startTimestampUtc: startTimestampUtc, endTimestampUtc: endTimestampUtc))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthMonitorStateChangeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get monitor state changes with expanded values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetMonitorStateChangesWithExpandedValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorHistory_GetExpanded.json
            // this example is just showing the usage of "HealthMonitors_ListStateChanges" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation and iterate over the result
            string expand = "evidence,configuration";
            DateTimeOffset? startTimestampUtc = DateTimeOffset.Parse("2020-10-19T07:22:25.824Z");
            DateTimeOffset? endTimestampUtc = DateTimeOffset.Parse("2020-10-21T13:22:25.822Z");
            await foreach (HealthMonitorStateChangeResource item in collection.GetAllAsync(expand: expand, startTimestampUtc: startTimestampUtc, endTimestampUtc: endTimestampUtc))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthMonitorStateChangeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get monitor state changes with filtered values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetMonitorStateChangesWithFilteredValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorHistory_GetFiltered.json
            // this example is just showing the usage of "HealthMonitors_ListStateChanges" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A|free-space";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation and iterate over the result
            string filter = "isHeartbeat eq false";
            DateTimeOffset? startTimestampUtc = DateTimeOffset.Parse("2020-01-04T20:20:18.5765757Z");
            DateTimeOffset? endTimestampUtc = DateTimeOffset.Parse("2020-01-09T20:20:18.5765757Z");
            await foreach (HealthMonitorStateChangeResource item in collection.GetAllAsync(filter: filter, startTimestampUtc: startTimestampUtc, endTimestampUtc: endTimestampUtc))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthMonitorStateChangeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get monitor state change with default values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMonitorStateChangeWithDefaultValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorStateChange_GetDefault.json
            // this example is just showing the usage of "HealthMonitors_GetStateChange" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation
            string timestampUnix = "1584316800";
            HealthMonitorStateChangeResource result = await collection.GetAsync(timestampUnix);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthMonitorStateChangeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get monitor state change with default values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetMonitorStateChangeWithDefaultValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorStateChange_GetDefault.json
            // this example is just showing the usage of "HealthMonitors_GetStateChange" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation
            string timestampUnix = "1584316800";
            bool result = await collection.ExistsAsync(timestampUnix);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get monitor state change with default values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetMonitorStateChangeWithDefaultValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorStateChange_GetDefault.json
            // this example is just showing the usage of "HealthMonitors_GetStateChange" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation
            string timestampUnix = "1584316800";
            NullableResponse<HealthMonitorStateChangeResource> response = await collection.GetIfExistsAsync(timestampUnix);
            HealthMonitorStateChangeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthMonitorStateChangeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get monitor state change with expanded values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMonitorStateChangeWithExpandedValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorStateChange_GetExpanded.json
            // this example is just showing the usage of "HealthMonitors_GetStateChange" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation
            string timestampUnix = "1584316800";
            string expand = "evidence";
            HealthMonitorStateChangeResource result = await collection.GetAsync(timestampUnix, expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthMonitorStateChangeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get monitor state change with expanded values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetMonitorStateChangeWithExpandedValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorStateChange_GetExpanded.json
            // this example is just showing the usage of "HealthMonitors_GetStateChange" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation
            string timestampUnix = "1584316800";
            string expand = "evidence";
            bool result = await collection.ExistsAsync(timestampUnix, expand: expand);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get monitor state change with expanded values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetMonitorStateChangeWithExpandedValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/MonitorStateChange_GetExpanded.json
            // this example is just showing the usage of "HealthMonitors_GetStateChange" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // get the collection of this HealthMonitorStateChangeResource
            HealthMonitorStateChangeCollection collection = healthMonitor.GetHealthMonitorStateChanges();

            // invoke the operation
            string timestampUnix = "1584316800";
            string expand = "evidence";
            NullableResponse<HealthMonitorStateChangeResource> response = await collection.GetIfExistsAsync(timestampUnix, expand: expand);
            HealthMonitorStateChangeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthMonitorStateChangeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
