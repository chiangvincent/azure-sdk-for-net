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
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearninRegistryComponentContainerResource
    {
        // Delete Registry Component Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRegistryComponentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/ComponentContainer/delete.json
            // this example is just showing the usage of "RegistryComponentContainers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearninRegistryComponentContainerResource created on azure
            // for more information of creating MachineLearninRegistryComponentContainerResource, please refer to the document of MachineLearninRegistryComponentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string componentName = "string";
            ResourceIdentifier machineLearninRegistryComponentContainerResourceId = MachineLearninRegistryComponentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, componentName);
            MachineLearninRegistryComponentContainerResource machineLearninRegistryComponentContainer = client.GetMachineLearninRegistryComponentContainerResource(machineLearninRegistryComponentContainerResourceId);

            // invoke the operation
            await machineLearninRegistryComponentContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Registry Component Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistryComponentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/ComponentContainer/get.json
            // this example is just showing the usage of "RegistryComponentContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearninRegistryComponentContainerResource created on azure
            // for more information of creating MachineLearninRegistryComponentContainerResource, please refer to the document of MachineLearninRegistryComponentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string componentName = "string";
            ResourceIdentifier machineLearninRegistryComponentContainerResourceId = MachineLearninRegistryComponentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, componentName);
            MachineLearninRegistryComponentContainerResource machineLearninRegistryComponentContainer = client.GetMachineLearninRegistryComponentContainerResource(machineLearninRegistryComponentContainerResourceId);

            // invoke the operation
            MachineLearninRegistryComponentContainerResource result = await machineLearninRegistryComponentContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningComponentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Registry Component Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateRegistryComponentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/ComponentContainer/createOrUpdate.json
            // this example is just showing the usage of "RegistryComponentContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearninRegistryComponentContainerResource created on azure
            // for more information of creating MachineLearninRegistryComponentContainerResource, please refer to the document of MachineLearninRegistryComponentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string componentName = "string";
            ResourceIdentifier machineLearninRegistryComponentContainerResourceId = MachineLearninRegistryComponentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, componentName);
            MachineLearninRegistryComponentContainerResource machineLearninRegistryComponentContainer = client.GetMachineLearninRegistryComponentContainerResource(machineLearninRegistryComponentContainerResourceId);

            // invoke the operation
            MachineLearningComponentContainerData data = new MachineLearningComponentContainerData(new MachineLearningComponentContainerProperties()
            {
                Description = "string",
                Properties =
{
["string"] = "string",
},
                Tags =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearninRegistryComponentContainerResource> lro = await machineLearninRegistryComponentContainer.UpdateAsync(WaitUntil.Completed, data);
            MachineLearninRegistryComponentContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningComponentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
