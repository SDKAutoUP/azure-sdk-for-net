// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// OpenId Connect Provider details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OpenidConnectProviderContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the OpenidConnectProviderContract
        /// class.
        /// </summary>
        public OpenidConnectProviderContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpenidConnectProviderContract
        /// class.
        /// </summary>
        /// <param name="displayName">User-friendly OpenID Connect Provider
        /// name.</param>
        /// <param name="metadataEndpoint">Metadata endpoint URI.</param>
        /// <param name="clientId">Client ID of developer console which is the
        /// client application.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="description">User-friendly description of OpenID
        /// Connect Provider.</param>
        /// <param name="clientSecret">Client Secret of developer console which
        /// is the client application.</param>
        public OpenidConnectProviderContract(string displayName, string metadataEndpoint, string clientId, string id = default(string), string name = default(string), string type = default(string), string description = default(string), string clientSecret = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Description = description;
            MetadataEndpoint = metadataEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user-friendly OpenID Connect Provider name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets user-friendly description of OpenID Connect Provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets metadata endpoint URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadataEndpoint")]
        public string MetadataEndpoint { get; set; }

        /// <summary>
        /// Gets or sets client ID of developer console which is the client
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets client Secret of developer console which is the client
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (MetadataEndpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetadataEndpoint");
            }
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 50);
                }
            }
        }
    }
}
