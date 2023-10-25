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
using Azure.ResourceManager.HybridContainerService;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridContainerService.Samples
{
    public partial class Sample_StorageSpaceResource
    {
        // GetStorageSpace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetStorageSpace()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/preview/2022-09-01-preview/examples/GetStorageSpace.json
            // this example is just showing the usage of "storageSpaces_Retrieve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSpaceResource created on azure
            // for more information of creating StorageSpaceResource, please refer to the document of StorageSpaceResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            string storageSpacesName = "test-storage";
            ResourceIdentifier storageSpaceResourceId = StorageSpaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSpacesName);
            StorageSpaceResource storageSpace = client.GetStorageSpaceResource(storageSpaceResourceId);

            // invoke the operation
            StorageSpaceResource result = await storageSpace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSpaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteStorageSpace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteStorageSpace()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/preview/2022-09-01-preview/examples/DeleteStorageSpace.json
            // this example is just showing the usage of "storageSpaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSpaceResource created on azure
            // for more information of creating StorageSpaceResource, please refer to the document of StorageSpaceResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            string storageSpacesName = "test-storage";
            ResourceIdentifier storageSpaceResourceId = StorageSpaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSpacesName);
            StorageSpaceResource storageSpace = client.GetStorageSpaceResource(storageSpaceResourceId);

            // invoke the operation
            await storageSpace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // UpdateStorageSpace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateStorageSpace()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/preview/2022-09-01-preview/examples/UpdateStorageSpace.json
            // this example is just showing the usage of "storageSpaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSpaceResource created on azure
            // for more information of creating StorageSpaceResource, please refer to the document of StorageSpaceResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            string storageSpacesName = "test-storage";
            ResourceIdentifier storageSpaceResourceId = StorageSpaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSpacesName);
            StorageSpaceResource storageSpace = client.GetStorageSpaceResource(storageSpaceResourceId);

            // invoke the operation
            StorageSpacePatch patch = new StorageSpacePatch()
            {
                Tags =
{
["additionalProperties"] = "sample",
},
            };
            ArmOperation<StorageSpaceResource> lro = await storageSpace.UpdateAsync(WaitUntil.Completed, patch);
            StorageSpaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSpaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListStorageSpaceBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStorageSpaces_ListStorageSpaceBySubscription()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/preview/2022-09-01-preview/examples/ListStorageSpaceBySubscription.json
            // this example is just showing the usage of "storageSpaces_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StorageSpaceResource item in subscriptionResource.GetStorageSpacesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageSpaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
