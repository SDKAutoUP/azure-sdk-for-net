// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureData.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A SqlManagedInstance.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlManagedInstance : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlManagedInstance class.
        /// </summary>
        public SqlManagedInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagedInstance class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="dataControllerId">null</param>
        /// <param name="instanceEndpoint">The on premise instance
        /// endpoint</param>
        /// <param name="admin">The instance admin user</param>
        /// <param name="startTime">The instance start time</param>
        /// <param name="endTime">The instance end time</param>
        /// <param name="vCore">The instance vCore</param>
        public SqlManagedInstance(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), string dataControllerId = default(string), string instanceEndpoint = default(string), string admin = default(string), string startTime = default(string), string endTime = default(string), string vCore = default(string))
            : base(location, id, name, type, tags, systemData)
        {
            DataControllerId = dataControllerId;
            InstanceEndpoint = instanceEndpoint;
            Admin = admin;
            StartTime = startTime;
            EndTime = endTime;
            VCore = vCore;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets null
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataControllerId")]
        public string DataControllerId { get; set; }

        /// <summary>
        /// Gets or sets the on premise instance endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceEndpoint")]
        public string InstanceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the instance admin user
        /// </summary>
        [JsonProperty(PropertyName = "properties.admin")]
        public string Admin { get; set; }

        /// <summary>
        /// Gets or sets the instance start time
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the instance end time
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the instance vCore
        /// </summary>
        [JsonProperty(PropertyName = "properties.vCore")]
        public string VCore { get; set; }

    }
}
