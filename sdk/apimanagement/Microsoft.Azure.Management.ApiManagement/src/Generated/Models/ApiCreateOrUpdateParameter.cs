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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// API Create or Update Parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApiCreateOrUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the ApiCreateOrUpdateParameter class.
        /// </summary>
        public ApiCreateOrUpdateParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiCreateOrUpdateParameter class.
        /// </summary>
        /// <param name="path">Relative URL uniquely identifying this API and
        /// all of its resource paths within the API Management service
        /// instance. It is appended to the API endpoint base URL specified
        /// during the service instance creation to form a public URL for this
        /// API.</param>
        /// <param name="description">Description of the API. May include HTML
        /// formatting tags.</param>
        /// <param name="authenticationSettings">Collection of authentication
        /// settings included into this API.</param>
        /// <param name="subscriptionKeyParameterNames">Protocols over which
        /// API is made available.</param>
        /// <param name="apiType">Type of API. Possible values include: 'http',
        /// 'soap'</param>
        /// <param name="apiRevision">Describes the Revision of the Api. If no
        /// value is provided, default revision 1 is created</param>
        /// <param name="apiVersion">Indicates the Version identifier of the
        /// API if the API is versioned</param>
        /// <param name="isCurrent">Indicates if API revision is current api
        /// revision.</param>
        /// <param name="isOnline">Indicates if API revision is accessible via
        /// the gateway.</param>
        /// <param name="apiRevisionDescription">Description of the Api
        /// Revision.</param>
        /// <param name="apiVersionDescription">Description of the Api
        /// Version.</param>
        /// <param name="apiVersionSetId">A resource identifier for the related
        /// ApiVersionSet.</param>
        /// <param name="subscriptionRequired">Specifies whether an API or
        /// Product subscription is required for accessing the API.</param>
        /// <param name="sourceApiId">API identifier of the source API.</param>
        /// <param name="displayName">API name. Must be 1 to 300 characters
        /// long.</param>
        /// <param name="serviceUrl">Absolute URL of the backend service
        /// implementing this API. Cannot be more than 2000 characters
        /// long.</param>
        /// <param name="protocols">Describes on which protocols the operations
        /// in this API can be invoked.</param>
        /// <param name="apiVersionSet">Version set details</param>
        /// <param name="value">Content value when Importing an API.</param>
        /// <param name="format">Format of the Content in which the API is
        /// getting imported. Possible values include: 'wadl-xml',
        /// 'wadl-link-json', 'swagger-json', 'swagger-link-json', 'wsdl',
        /// 'wsdl-link', 'openapi', 'openapi+json', 'openapi-link',
        /// 'openapi+json-link'</param>
        /// <param name="wsdlSelector">Criteria to limit import of WSDL to a
        /// subset of the document.</param>
        /// <param name="soapApiType">Type of Api to create.
        /// * `http` creates a SOAP to REST API
        /// * `soap` creates a SOAP pass-through API. Possible values include:
        /// 'SoapToRest', 'SoapPassThrough'</param>
        public ApiCreateOrUpdateParameter(string path, string description = default(string), AuthenticationSettingsContract authenticationSettings = default(AuthenticationSettingsContract), SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default(SubscriptionKeyParameterNamesContract), string apiType = default(string), string apiRevision = default(string), string apiVersion = default(string), bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = default(string), string apiVersionDescription = default(string), string apiVersionSetId = default(string), bool? subscriptionRequired = default(bool?), string sourceApiId = default(string), string displayName = default(string), string serviceUrl = default(string), IList<Protocol?> protocols = default(IList<Protocol?>), ApiVersionSetContractDetails apiVersionSet = default(ApiVersionSetContractDetails), string value = default(string), string format = default(string), ApiCreateOrUpdatePropertiesWsdlSelector wsdlSelector = default(ApiCreateOrUpdatePropertiesWsdlSelector), string soapApiType = default(string))
        {
            Description = description;
            AuthenticationSettings = authenticationSettings;
            SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
            ApiType = apiType;
            ApiRevision = apiRevision;
            ApiVersion = apiVersion;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            ApiRevisionDescription = apiRevisionDescription;
            ApiVersionDescription = apiVersionDescription;
            ApiVersionSetId = apiVersionSetId;
            SubscriptionRequired = subscriptionRequired;
            SourceApiId = sourceApiId;
            DisplayName = displayName;
            ServiceUrl = serviceUrl;
            Path = path;
            Protocols = protocols;
            ApiVersionSet = apiVersionSet;
            Value = value;
            Format = format;
            WsdlSelector = wsdlSelector;
            SoapApiType = soapApiType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the API. May include HTML formatting
        /// tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets collection of authentication settings included into
        /// this API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationSettings")]
        public AuthenticationSettingsContract AuthenticationSettings { get; set; }

        /// <summary>
        /// Gets or sets protocols over which API is made available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionKeyParameterNames")]
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; set; }

        /// <summary>
        /// Gets or sets type of API. Possible values include: 'http', 'soap'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string ApiType { get; set; }

        /// <summary>
        /// Gets or sets describes the Revision of the Api. If no value is
        /// provided, default revision 1 is created
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiRevision")]
        public string ApiRevision { get; set; }

        /// <summary>
        /// Gets or sets indicates the Version identifier of the API if the API
        /// is versioned
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates if API revision is current api revision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCurrent")]
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// Gets indicates if API revision is accessible via the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isOnline")]
        public bool? IsOnline { get; private set; }

        /// <summary>
        /// Gets or sets description of the Api Revision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiRevisionDescription")]
        public string ApiRevisionDescription { get; set; }

        /// <summary>
        /// Gets or sets description of the Api Version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersionDescription")]
        public string ApiVersionDescription { get; set; }

        /// <summary>
        /// Gets or sets a resource identifier for the related ApiVersionSet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersionSetId")]
        public string ApiVersionSetId { get; set; }

        /// <summary>
        /// Gets or sets specifies whether an API or Product subscription is
        /// required for accessing the API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionRequired")]
        public bool? SubscriptionRequired { get; set; }

        /// <summary>
        /// Gets or sets API identifier of the source API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceApiId")]
        public string SourceApiId { get; set; }

        /// <summary>
        /// Gets or sets API name. Must be 1 to 300 characters long.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets absolute URL of the backend service implementing this
        /// API. Cannot be more than 2000 characters long.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets relative URL uniquely identifying this API and all of
        /// its resource paths within the API Management service instance. It
        /// is appended to the API endpoint base URL specified during the
        /// service instance creation to form a public URL for this API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets describes on which protocols the operations in this
        /// API can be invoked.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocols")]
        public IList<Protocol?> Protocols { get; set; }

        /// <summary>
        /// Gets or sets version set details
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersionSet")]
        public ApiVersionSetContractDetails ApiVersionSet { get; set; }

        /// <summary>
        /// Gets or sets content value when Importing an API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets format of the Content in which the API is getting
        /// imported. Possible values include: 'wadl-xml', 'wadl-link-json',
        /// 'swagger-json', 'swagger-link-json', 'wsdl', 'wsdl-link',
        /// 'openapi', 'openapi+json', 'openapi-link', 'openapi+json-link'
        /// </summary>
        [JsonProperty(PropertyName = "properties.format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets criteria to limit import of WSDL to a subset of the
        /// document.
        /// </summary>
        [JsonProperty(PropertyName = "properties.wsdlSelector")]
        public ApiCreateOrUpdatePropertiesWsdlSelector WsdlSelector { get; set; }

        /// <summary>
        /// Gets or sets type of Api to create.
        /// * `http` creates a SOAP to REST API
        /// * `soap` creates a SOAP pass-through API. Possible values include:
        /// 'SoapToRest', 'SoapPassThrough'
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiType")]
        public string SoapApiType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (ApiRevision != null)
            {
                if (ApiRevision.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevision", 100);
                }
                if (ApiRevision.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ApiRevision", 1);
                }
            }
            if (ApiVersion != null)
            {
                if (ApiVersion.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiVersion", 100);
                }
            }
            if (ApiRevisionDescription != null)
            {
                if (ApiRevisionDescription.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevisionDescription", 256);
                }
            }
            if (ApiVersionDescription != null)
            {
                if (ApiVersionDescription.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiVersionDescription", 256);
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 300);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
            }
            if (ServiceUrl != null)
            {
                if (ServiceUrl.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ServiceUrl", 2000);
                }
                if (ServiceUrl.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ServiceUrl", 0);
                }
            }
            if (Path != null)
            {
                if (Path.Length > 400)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Path", 400);
                }
                if (Path.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Path", 0);
                }
            }
        }
    }
}
