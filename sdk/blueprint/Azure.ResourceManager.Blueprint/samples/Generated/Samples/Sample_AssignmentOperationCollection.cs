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
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Samples
{
    public partial class Sample_AssignmentOperationCollection
    {
        // Assignment at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AssignmentAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignmentOperation_List.json
            // this example is just showing the usage of "AssignmentOperations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "managementGroups/ContosoOnlineGroup";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation and iterate over the result
            await foreach (AssignmentOperationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssignmentOperationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Assignment at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AssignmentAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignmentOperation_List.json
            // this example is just showing the usage of "AssignmentOperations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation and iterate over the result
            await foreach (AssignmentOperationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssignmentOperationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Assignment at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AssignmentAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignmentOperation_Get.json
            // this example is just showing the usage of "AssignmentOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "managementGroups/ContosoOnlineGroup";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation
            string assignmentOperationName = "fb5d4dcb-7ce2-4087-ba7a-459aa74e5e0f";
            AssignmentOperationResource result = await collection.GetAsync(assignmentOperationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentOperationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AssignmentAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignmentOperation_Get.json
            // this example is just showing the usage of "AssignmentOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "managementGroups/ContosoOnlineGroup";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation
            string assignmentOperationName = "fb5d4dcb-7ce2-4087-ba7a-459aa74e5e0f";
            bool result = await collection.ExistsAsync(assignmentOperationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Assignment at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_AssignmentAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignmentOperation_Get.json
            // this example is just showing the usage of "AssignmentOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "managementGroups/ContosoOnlineGroup";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation
            string assignmentOperationName = "fb5d4dcb-7ce2-4087-ba7a-459aa74e5e0f";
            NullableResponse<AssignmentOperationResource> response = await collection.GetIfExistsAsync(assignmentOperationName);
            AssignmentOperationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssignmentOperationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Assignment at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AssignmentAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignmentOperation_Get.json
            // this example is just showing the usage of "AssignmentOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation
            string assignmentOperationName = "fb5d4dcb-7ce2-4087-ba7a-459aa74e5e0f";
            AssignmentOperationResource result = await collection.GetAsync(assignmentOperationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentOperationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AssignmentAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignmentOperation_Get.json
            // this example is just showing the usage of "AssignmentOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation
            string assignmentOperationName = "fb5d4dcb-7ce2-4087-ba7a-459aa74e5e0f";
            bool result = await collection.ExistsAsync(assignmentOperationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Assignment at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_AssignmentAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignmentOperation_Get.json
            // this example is just showing the usage of "AssignmentOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssignmentResource created on azure
            // for more information of creating AssignmentResource, please refer to the document of AssignmentResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string assignmentName = "assignSimpleBlueprint";
            ResourceIdentifier assignmentResourceId = AssignmentResource.CreateResourceIdentifier(resourceScope, assignmentName);
            AssignmentResource assignment = client.GetAssignmentResource(assignmentResourceId);

            // get the collection of this AssignmentOperationResource
            AssignmentOperationCollection collection = assignment.GetAssignmentOperations();

            // invoke the operation
            string assignmentOperationName = "fb5d4dcb-7ce2-4087-ba7a-459aa74e5e0f";
            NullableResponse<AssignmentOperationResource> response = await collection.GetIfExistsAsync(assignmentOperationName);
            AssignmentOperationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssignmentOperationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
