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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteDiagnosticCollection
    {
        // List App Diagnostic Categories
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAppDiagnosticCategories()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_ListSiteDiagnosticCategories.json
            // this example is just showing the usage of "Diagnostics_ListSiteDiagnosticCategories" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation and iterate over the result
            await foreach (SiteDiagnosticResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List App Slot Diagnostic Categories
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAppSlotDiagnosticCategories()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_ListSiteDiagnosticCategoriesSlot.json
            // this example is just showing the usage of "Diagnostics_ListSiteDiagnosticCategories" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation and iterate over the result
            await foreach (SiteDiagnosticResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get App Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            SiteDiagnosticResource result = await collection.GetAsync(diagnosticCategory);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            bool result = await collection.ExistsAsync(diagnosticCategory);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get App Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            NullableResponse<SiteDiagnosticResource> response = await collection.GetIfExistsAsync(diagnosticCategory);
            SiteDiagnosticResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get App Slot Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            SiteDiagnosticResource result = await collection.GetAsync(diagnosticCategory);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Slot Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            bool result = await collection.ExistsAsync(diagnosticCategory);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get App Slot Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDiagnosticResource
            SiteDiagnosticCollection collection = webSite.GetSiteDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            NullableResponse<SiteDiagnosticResource> response = await collection.GetIfExistsAsync(diagnosticCategory);
            SiteDiagnosticResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
