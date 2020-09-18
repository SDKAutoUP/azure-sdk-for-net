// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Application Insights component definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationInsightsComponent : ComponentsResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationInsightsComponent
        /// class.
        /// </summary>
        public ApplicationInsightsComponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationInsightsComponent
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="kind">The kind of application that this component
        /// refers to, used to customize UI. This value is a freeform string,
        /// values should typically be one of the following: web, ios, other,
        /// store, java, phone.</param>
        /// <param name="applicationType">Type of application being monitored.
        /// Possible values include: 'web', 'other'</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="applicationId">The unique ID of your application. This
        /// field mirrors the 'Name' field and cannot be changed.</param>
        /// <param name="appId">Application Insights Unique ID for your
        /// Application.</param>
        /// <param name="flowType">Used by the Application Insights system to
        /// determine what kind of flow this component was created by. This is
        /// to be set to 'Bluefield' when creating/updating a component via the
        /// REST API. Possible values include: 'Bluefield'</param>
        /// <param name="requestSource">Describes what tool created this
        /// Application Insights component. Customers using this API should set
        /// this to the default 'rest'. Possible values include: 'rest'</param>
        /// <param name="instrumentationKey">Application Insights
        /// Instrumentation key. A read-only value that applications can use to
        /// identify the destination for all telemetry sent to Azure
        /// Application Insights. This value will be supplied upon construction
        /// of each new Application Insights component.</param>
        /// <param name="creationDate">Creation Date for the Application
        /// Insights component, in ISO 8601 format.</param>
        /// <param name="tenantId">Azure Tenant Id.</param>
        /// <param name="hockeyAppId">The unique application ID created when a
        /// new application is added to HockeyApp, used for communications with
        /// HockeyApp.</param>
        /// <param name="hockeyAppToken">Token used to authenticate
        /// communications with between Application Insights and
        /// HockeyApp.</param>
        /// <param name="provisioningState">Current state of this component:
        /// whether or not is has been provisioned within the resource group it
        /// is defined. Users cannot change this value but are able to read
        /// from it. Values will include Succeeded, Deploying, Canceled, and
        /// Failed.</param>
        /// <param name="samplingPercentage">Percentage of the data produced by
        /// the application being monitored that is being sampled for
        /// Application Insights telemetry.</param>
        /// <param name="connectionString">Application Insights component
        /// connection string.</param>
        /// <param name="retentionInDays">Retention period in days.</param>
        /// <param name="disableIpMasking">Disable IP masking.</param>
        /// <param name="immediatePurgeDataOn30Days">Purge data immediately
        /// after 30 days.</param>
        /// <param name="privateLinkScopedResources">List of linked private
        /// link scope resources.</param>
        /// <param name="publicNetworkAccessForIngestion">The network access
        /// type for accessing Application Insights ingestion. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="publicNetworkAccessForQuery">The network access type
        /// for accessing Application Insights query. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="ingestionMode">Indicates the flow of the ingestion.
        /// Possible values include: 'ApplicationInsights',
        /// 'ApplicationInsightsWithDiagnosticSettings', 'LogAnalytics'</param>
        public ApplicationInsightsComponent(string location, string kind, string applicationType, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string applicationId = default(string), string appId = default(string), string flowType = default(string), string requestSource = default(string), string instrumentationKey = default(string), System.DateTime? creationDate = default(System.DateTime?), string tenantId = default(string), string hockeyAppId = default(string), string hockeyAppToken = default(string), string provisioningState = default(string), double? samplingPercentage = default(double?), string connectionString = default(string), int? retentionInDays = default(int?), bool? disableIpMasking = default(bool?), bool? immediatePurgeDataOn30Days = default(bool?), IList<PrivateLinkScopedResource> privateLinkScopedResources = default(IList<PrivateLinkScopedResource>), string publicNetworkAccessForIngestion = default(string), string publicNetworkAccessForQuery = default(string), string ingestionMode = default(string))
            : base(location, id, name, type, tags)
        {
            Kind = kind;
            ApplicationId = applicationId;
            AppId = appId;
            ApplicationType = applicationType;
            FlowType = flowType;
            RequestSource = requestSource;
            InstrumentationKey = instrumentationKey;
            CreationDate = creationDate;
            TenantId = tenantId;
            HockeyAppId = hockeyAppId;
            HockeyAppToken = hockeyAppToken;
            ProvisioningState = provisioningState;
            SamplingPercentage = samplingPercentage;
            ConnectionString = connectionString;
            RetentionInDays = retentionInDays;
            DisableIpMasking = disableIpMasking;
            ImmediatePurgeDataOn30Days = immediatePurgeDataOn30Days;
            PrivateLinkScopedResources = privateLinkScopedResources;
            PublicNetworkAccessForIngestion = publicNetworkAccessForIngestion;
            PublicNetworkAccessForQuery = publicNetworkAccessForQuery;
            IngestionMode = ingestionMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the kind of application that this component refers to,
        /// used to customize UI. This value is a freeform string, values
        /// should typically be one of the following: web, ios, other, store,
        /// java, phone.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets the unique ID of your application. This field mirrors the
        /// 'Name' field and cannot be changed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ApplicationId")]
        public string ApplicationId { get; private set; }

        /// <summary>
        /// Gets application Insights Unique ID for your Application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.AppId")]
        public string AppId { get; private set; }

        /// <summary>
        /// Gets or sets type of application being monitored. Possible values
        /// include: 'web', 'other'
        /// </summary>
        [JsonProperty(PropertyName = "properties.Application_Type")]
        public string ApplicationType { get; set; }

        /// <summary>
        /// Gets or sets used by the Application Insights system to determine
        /// what kind of flow this component was created by. This is to be set
        /// to 'Bluefield' when creating/updating a component via the REST API.
        /// Possible values include: 'Bluefield'
        /// </summary>
        [JsonProperty(PropertyName = "properties.Flow_Type")]
        public string FlowType { get; set; }

        /// <summary>
        /// Gets or sets describes what tool created this Application Insights
        /// component. Customers using this API should set this to the default
        /// 'rest'. Possible values include: 'rest'
        /// </summary>
        [JsonProperty(PropertyName = "properties.Request_Source")]
        public string RequestSource { get; set; }

        /// <summary>
        /// Gets application Insights Instrumentation key. A read-only value
        /// that applications can use to identify the destination for all
        /// telemetry sent to Azure Application Insights. This value will be
        /// supplied upon construction of each new Application Insights
        /// component.
        /// </summary>
        [JsonProperty(PropertyName = "properties.InstrumentationKey")]
        public string InstrumentationKey { get; private set; }

        /// <summary>
        /// Gets creation Date for the Application Insights component, in ISO
        /// 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.CreationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets azure Tenant Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.TenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the unique application ID created when a new
        /// application is added to HockeyApp, used for communications with
        /// HockeyApp.
        /// </summary>
        [JsonProperty(PropertyName = "properties.HockeyAppId")]
        public string HockeyAppId { get; set; }

        /// <summary>
        /// Gets token used to authenticate communications with between
        /// Application Insights and HockeyApp.
        /// </summary>
        [JsonProperty(PropertyName = "properties.HockeyAppToken")]
        public string HockeyAppToken { get; private set; }

        /// <summary>
        /// Gets current state of this component: whether or not is has been
        /// provisioned within the resource group it is defined. Users cannot
        /// change this value but are able to read from it. Values will include
        /// Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets percentage of the data produced by the application
        /// being monitored that is being sampled for Application Insights
        /// telemetry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SamplingPercentage")]
        public double? SamplingPercentage { get; set; }

        /// <summary>
        /// Gets application Insights component connection string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ConnectionString")]
        public string ConnectionString { get; private set; }

        /// <summary>
        /// Gets or sets retention period in days.
        /// </summary>
        [JsonProperty(PropertyName = "properties.RetentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets disable IP masking.
        /// </summary>
        [JsonProperty(PropertyName = "properties.DisableIpMasking")]
        public bool? DisableIpMasking { get; set; }

        /// <summary>
        /// Gets or sets purge data immediately after 30 days.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ImmediatePurgeDataOn30Days")]
        public bool? ImmediatePurgeDataOn30Days { get; set; }

        /// <summary>
        /// Gets list of linked private link scope resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.PrivateLinkScopedResources")]
        public IList<PrivateLinkScopedResource> PrivateLinkScopedResources { get; private set; }

        /// <summary>
        /// Gets or sets the network access type for accessing Application
        /// Insights ingestion. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccessForIngestion")]
        public string PublicNetworkAccessForIngestion { get; set; }

        /// <summary>
        /// Gets or sets the network access type for accessing Application
        /// Insights query. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccessForQuery")]
        public string PublicNetworkAccessForQuery { get; set; }

        /// <summary>
        /// Gets or sets indicates the flow of the ingestion. Possible values
        /// include: 'ApplicationInsights',
        /// 'ApplicationInsightsWithDiagnosticSettings', 'LogAnalytics'
        /// </summary>
        [JsonProperty(PropertyName = "properties.IngestionMode")]
        public string IngestionMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (ApplicationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplicationType");
            }
        }
    }
}
