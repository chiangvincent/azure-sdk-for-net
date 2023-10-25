// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class ImageRepositoryCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("imageRepositoryUrl"u8);
            writer.WriteStringValue(ImageRepositoryUri.AbsoluteUri);
            writer.WritePropertyName("userName"u8);
            writer.WriteStringValue(UserName);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            writer.WriteEndObject();
        }

        internal static ImageRepositoryCredential DeserializeImageRepositoryCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri imageRepositoryUrl = default;
            string userName = default;
            Optional<AsymmetricEncryptedSecret> password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageRepositoryUrl"u8))
                {
                    imageRepositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    password = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property.Value);
                    continue;
                }
            }
            return new ImageRepositoryCredential(imageRepositoryUrl, userName, password.Value);
        }
    }
}
