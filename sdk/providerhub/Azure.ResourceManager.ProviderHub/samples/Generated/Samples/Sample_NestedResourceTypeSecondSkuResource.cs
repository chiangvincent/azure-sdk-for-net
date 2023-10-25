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
using Azure.ResourceManager.ProviderHub;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_NestedResourceTypeSecondSkuResource
    {
        // Skus_GetNestedResourceTypeSecond
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SkusGetNestedResourceTypeSecond()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_GetNestedResourceTypeSecond.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeSecond" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeSecondSkuResource created on azure
            // for more information of creating NestedResourceTypeSecondSkuResource, please refer to the document of NestedResourceTypeSecondSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeSecondSkuResourceId = NestedResourceTypeSecondSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, nestedResourceTypeSecond, sku);
            NestedResourceTypeSecondSkuResource nestedResourceTypeSecondSku = client.GetNestedResourceTypeSecondSkuResource(nestedResourceTypeSecondSkuResourceId);

            // invoke the operation
            NestedResourceTypeSecondSkuResource result = await nestedResourceTypeSecondSku.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_CreateOrUpdateNestedResourceTypeSecond
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SkusCreateOrUpdateNestedResourceTypeSecond()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_CreateOrUpdateNestedResourceTypeSecond.json
            // this example is just showing the usage of "Skus_CreateOrUpdateNestedResourceTypeSecond" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeSecondSkuResource created on azure
            // for more information of creating NestedResourceTypeSecondSkuResource, please refer to the document of NestedResourceTypeSecondSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeSecondSkuResourceId = NestedResourceTypeSecondSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, nestedResourceTypeSecond, sku);
            NestedResourceTypeSecondSkuResource nestedResourceTypeSecondSku = client.GetNestedResourceTypeSecondSkuResource(nestedResourceTypeSecondSkuResourceId);

            // invoke the operation
            ResourceTypeSkuData data = new ResourceTypeSkuData()
            {
                Properties = new ResourceTypeSkuProperties(new ResourceTypeSkuSetting[]
            {
new ResourceTypeSkuSetting("freeSku")
{
Tier = "Tier1",
Kind = "Standard",
},new ResourceTypeSkuSetting("premiumSku")
{
Tier = "Tier2",
Kind = "Premium",
Costs =
{
new ResourceTypeSkuCost("xxx")
},
}
            }),
            };
            ArmOperation<NestedResourceTypeSecondSkuResource> lro = await nestedResourceTypeSecondSku.UpdateAsync(WaitUntil.Completed, data);
            NestedResourceTypeSecondSkuResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_DeleteNestedResourceTypeSecond
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SkusDeleteNestedResourceTypeSecond()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_DeleteNestedResourceTypeSecond.json
            // this example is just showing the usage of "Skus_DeleteNestedResourceTypeSecond" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeSecondSkuResource created on azure
            // for more information of creating NestedResourceTypeSecondSkuResource, please refer to the document of NestedResourceTypeSecondSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeSecondSkuResourceId = NestedResourceTypeSecondSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, nestedResourceTypeSecond, sku);
            NestedResourceTypeSecondSkuResource nestedResourceTypeSecondSku = client.GetNestedResourceTypeSecondSkuResource(nestedResourceTypeSecondSkuResourceId);

            // invoke the operation
            await nestedResourceTypeSecondSku.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
