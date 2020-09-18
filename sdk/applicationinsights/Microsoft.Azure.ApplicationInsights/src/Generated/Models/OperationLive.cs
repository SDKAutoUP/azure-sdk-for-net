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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents an operation returned by the GetOperations request
    /// </summary>
    public partial class OperationLive
    {
        /// <summary>
        /// Initializes a new instance of the OperationLive class.
        /// </summary>
        public OperationLive()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationLive class.
        /// </summary>
        /// <param name="name">Name of the operation</param>
        /// <param name="display">Display name of the operation</param>
        /// <param name="origin">Origin of the operation</param>
        /// <param name="properties">Properties of the operation</param>
        public OperationLive(string name = default(string), OperationInfo display = default(OperationInfo), string origin = default(string), object properties = default(object))
        {
            Name = name;
            Display = display;
            Origin = origin;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the operation
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of the operation
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationInfo Display { get; set; }

        /// <summary>
        /// Gets or sets origin of the operation
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets properties of the operation
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
