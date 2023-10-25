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
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_DataCollectionRuleAssociationResource
    {
        // Get association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsGet.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataCollectionRuleAssociationResource created on azure
            // for more information of creating DataCollectionRuleAssociationResource, please refer to the document of DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            string associationName = "myAssociation";
            ResourceIdentifier dataCollectionRuleAssociationResourceId = DataCollectionRuleAssociationResource.CreateResourceIdentifier(resourceUri, associationName);
            DataCollectionRuleAssociationResource dataCollectionRuleAssociation = client.GetDataCollectionRuleAssociationResource(dataCollectionRuleAssociationResourceId);

            // invoke the operation
            DataCollectionRuleAssociationResource result = await dataCollectionRuleAssociation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataCollectionRuleAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsCreate.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataCollectionRuleAssociationResource created on azure
            // for more information of creating DataCollectionRuleAssociationResource, please refer to the document of DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            string associationName = "myAssociation";
            ResourceIdentifier dataCollectionRuleAssociationResourceId = DataCollectionRuleAssociationResource.CreateResourceIdentifier(resourceUri, associationName);
            DataCollectionRuleAssociationResource dataCollectionRuleAssociation = client.GetDataCollectionRuleAssociationResource(dataCollectionRuleAssociationResourceId);

            // invoke the operation
            DataCollectionRuleAssociationData data = new DataCollectionRuleAssociationData()
            {
                DataCollectionRuleId = new ResourceIdentifier("/subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Insights/dataCollectionRules/myCollectionRule"),
            };
            ArmOperation<DataCollectionRuleAssociationResource> lro = await dataCollectionRuleAssociation.UpdateAsync(WaitUntil.Completed, data);
            DataCollectionRuleAssociationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataCollectionRuleAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsDelete.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataCollectionRuleAssociationResource created on azure
            // for more information of creating DataCollectionRuleAssociationResource, please refer to the document of DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            string associationName = "myAssociation";
            ResourceIdentifier dataCollectionRuleAssociationResourceId = DataCollectionRuleAssociationResource.CreateResourceIdentifier(resourceUri, associationName);
            DataCollectionRuleAssociationResource dataCollectionRuleAssociation = client.GetDataCollectionRuleAssociationResource(dataCollectionRuleAssociationResourceId);

            // invoke the operation
            await dataCollectionRuleAssociation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
