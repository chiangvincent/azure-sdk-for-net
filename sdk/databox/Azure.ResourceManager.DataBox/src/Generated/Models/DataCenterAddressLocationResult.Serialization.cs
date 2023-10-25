// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataCenterAddressLocationResult
    {
        internal static DataCenterAddressLocationResult DeserializeDataCenterAddressLocationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> contactPersonName = default;
            Optional<string> company = default;
            Optional<string> street1 = default;
            Optional<string> street2 = default;
            Optional<string> street3 = default;
            Optional<string> city = default;
            Optional<string> state = default;
            Optional<string> zip = default;
            Optional<string> country = default;
            Optional<string> phone = default;
            Optional<string> phoneExtension = default;
            Optional<string> addressType = default;
            Optional<string> additionalShippingInformation = default;
            DataCenterAddressType dataCenterAddressType = default;
            Optional<IReadOnlyList<string>> supportedCarriersForReturnShipment = default;
            Optional<AzureLocation> dataCenterAzureLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactPersonName"u8))
                {
                    contactPersonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("company"u8))
                {
                    company = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street1"u8))
                {
                    street1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street2"u8))
                {
                    street2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street3"u8))
                {
                    street3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zip"u8))
                {
                    zip = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneExtension"u8))
                {
                    phoneExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"u8))
                {
                    addressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalShippingInformation"u8))
                {
                    additionalShippingInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datacenterAddressType"u8))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
            }
            return new DataCenterAddressLocationResult(dataCenterAddressType, Optional.ToList(supportedCarriersForReturnShipment), Optional.ToNullable(dataCenterAzureLocation), contactPersonName.Value, company.Value, street1.Value, street2.Value, street3.Value, city.Value, state.Value, zip.Value, country.Value, phone.Value, phoneExtension.Value, addressType.Value, additionalShippingInformation.Value);
        }
    }
}
