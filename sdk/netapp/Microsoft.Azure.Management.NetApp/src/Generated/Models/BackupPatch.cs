// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Backup patch
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupPatch : IResource
    {
        /// <summary>
        /// Initializes a new instance of the BackupPatch class.
        /// </summary>
        public BackupPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupPatch class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="creationDate">name</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="size">Size of backup</param>
        /// <param name="label">Label for backup</param>
        /// <param name="backupType">Type of backup adhoc or scheduled</param>
        public BackupPatch(IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? creationDate = default(System.DateTime?), string provisioningState = default(string), long? size = default(long?), string label = default(string), string backupType = default(string))
        {
            Tags = tags;
            CreationDate = creationDate;
            ProvisioningState = provisioningState;
            Size = size;
            Label = label;
            BackupType = backupType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets name
        /// </summary>
        /// <remarks>
        /// The creation date of the backup
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets size of backup
        /// </summary>
        [JsonProperty(PropertyName = "properties.size")]
        public long? Size { get; private set; }

        /// <summary>
        /// Gets or sets label for backup
        /// </summary>
        [JsonProperty(PropertyName = "properties.label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets type of backup adhoc or scheduled
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupType")]
        public string BackupType { get; private set; }

    }
}
