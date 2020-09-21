// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The connector setting
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectorSetting : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorSetting class.
        /// </summary>
        public ConnectorSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorSetting class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="hybridComputeSettings">Settings for hybrid compute
        /// management, these settings are relevant only Arc autoProvision
        /// (Hybrid Compute).</param>
        /// <param name="authenticationDetails">Settings for authentication
        /// management, these settings are relevant only for the cloud
        /// connector.</param>
        public ConnectorSetting(string id = default(string), string name = default(string), string type = default(string), HybridComputeSettingsProperties hybridComputeSettings = default(HybridComputeSettingsProperties), AuthenticationDetailsProperties authenticationDetails = default(AuthenticationDetailsProperties))
            : base(id, name, type)
        {
            HybridComputeSettings = hybridComputeSettings;
            AuthenticationDetails = authenticationDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets settings for hybrid compute management, these settings
        /// are relevant only Arc autoProvision (Hybrid Compute).
        /// </summary>
        [JsonProperty(PropertyName = "properties.hybridComputeSettings")]
        public HybridComputeSettingsProperties HybridComputeSettings { get; set; }

        /// <summary>
        /// Gets or sets settings for authentication management, these settings
        /// are relevant only for the cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationDetails")]
        public AuthenticationDetailsProperties AuthenticationDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HybridComputeSettings != null)
            {
                HybridComputeSettings.Validate();
            }
        }
    }
}
