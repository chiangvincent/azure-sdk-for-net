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
using Azure.ResourceManager.AppContainers;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppManagedCertificateResource
    {
        // Get Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ManagedCertificate_Get.json
            // this example is just showing the usage of "ManagedCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedCertificateResource created on azure
            // for more information of creating ContainerAppManagedCertificateResource, please refer to the document of ContainerAppManagedCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string managedCertificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppManagedCertificateResourceId = ContainerAppManagedCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, managedCertificateName);
            ContainerAppManagedCertificateResource containerAppManagedCertificate = client.GetContainerAppManagedCertificateResource(containerAppManagedCertificateResourceId);

            // invoke the operation
            ContainerAppManagedCertificateResource result = await containerAppManagedCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ManagedCertificate_Delete.json
            // this example is just showing the usage of "ManagedCertificates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedCertificateResource created on azure
            // for more information of creating ContainerAppManagedCertificateResource, please refer to the document of ContainerAppManagedCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string managedCertificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppManagedCertificateResourceId = ContainerAppManagedCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, managedCertificateName);
            ContainerAppManagedCertificateResource containerAppManagedCertificate = client.GetContainerAppManagedCertificateResource(containerAppManagedCertificateResourceId);

            // invoke the operation
            await containerAppManagedCertificate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch Managed Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchManagedCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ManagedCertificates_Patch.json
            // this example is just showing the usage of "ManagedCertificates_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedCertificateResource created on azure
            // for more information of creating ContainerAppManagedCertificateResource, please refer to the document of ContainerAppManagedCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string managedCertificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppManagedCertificateResourceId = ContainerAppManagedCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, managedCertificateName);
            ContainerAppManagedCertificateResource containerAppManagedCertificate = client.GetContainerAppManagedCertificateResource(containerAppManagedCertificateResourceId);

            // invoke the operation
            ContainerAppManagedCertificatePatch patch = new ContainerAppManagedCertificatePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ContainerAppManagedCertificateResource result = await containerAppManagedCertificate.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
