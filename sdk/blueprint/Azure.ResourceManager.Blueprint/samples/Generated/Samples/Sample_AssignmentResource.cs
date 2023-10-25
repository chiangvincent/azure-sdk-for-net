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
using Azure.ResourceManager.Blueprint.Models;

namespace Azure.ResourceManager.Blueprint.Samples
{
    public partial class Sample_AssignmentResource
    {
        // Assignment at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AssignmentAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignment_Get.json
            // this example is just showing the usage of "Assignments_Get" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            AssignmentResource result = await assignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AssignmentAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignment_Get.json
            // this example is just showing the usage of "Assignments_Get" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            AssignmentResource result = await assignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment_Delete at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AssignmentDeleteAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignment_Delete.json
            // this example is just showing the usage of "Assignments_Delete" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            ArmOperation<AssignmentResource> lro = await assignment.DeleteAsync(WaitUntil.Completed);
            AssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment_Delete at management group scope, and delete the resources created by the assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AssignmentDeleteAtManagementGroupScopeAndDeleteTheResourcesCreatedByTheAssignment()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/BlueprintAssignment_Delete_AndDeleteChildren.json
            // this example is just showing the usage of "Assignments_Delete" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            AssignmentDeleteBehavior? deleteBehavior = AssignmentDeleteBehavior.All;
            ArmOperation<AssignmentResource> lro = await assignment.DeleteAsync(WaitUntil.Completed, deleteBehavior: deleteBehavior);
            AssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment_Delete at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AssignmentDeleteAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignment_Delete.json
            // this example is just showing the usage of "Assignments_Delete" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            ArmOperation<AssignmentResource> lro = await assignment.DeleteAsync(WaitUntil.Completed);
            AssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assignment_Delete at subscription scope, and delete the resources created by the assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AssignmentDeleteAtSubscriptionScopeAndDeleteTheResourcesCreatedByTheAssignment()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/BlueprintAssignment_Delete_AndDeleteChildren.json
            // this example is just showing the usage of "Assignments_Delete" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            AssignmentDeleteBehavior? deleteBehavior = AssignmentDeleteBehavior.All;
            ArmOperation<AssignmentResource> lro = await assignment.DeleteAsync(WaitUntil.Completed, deleteBehavior: deleteBehavior);
            AssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WhoIsBlueprint_Action at management group scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task WhoIsBlueprint_WhoIsBlueprintActionAtManagementGroupScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPAssignment/WhoIsBlueprint_Action.json
            // this example is just showing the usage of "Assignments_WhoIsBlueprint" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            WhoIsBlueprintContract result = await assignment.WhoIsBlueprintAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // WhoIsBlueprint_Action at subscription scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task WhoIsBlueprint_WhoIsBlueprintActionAtSubscriptionScope()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPAssignment/WhoIsBlueprint_Action.json
            // this example is just showing the usage of "Assignments_WhoIsBlueprint" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            WhoIsBlueprintContract result = await assignment.WhoIsBlueprintAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
