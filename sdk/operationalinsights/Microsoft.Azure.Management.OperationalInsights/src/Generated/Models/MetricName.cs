// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The name of a metric.
    /// </summary>
    public partial class MetricName
    {
        /// <summary>
        /// Initializes a new instance of the MetricName class.
        /// </summary>
        public MetricName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricName class.
        /// </summary>
        /// <param name="value">The system name of the metric.</param>
        /// <param name="localizedValue">The localized name of the
        /// metric.</param>
        public MetricName(string value = default(string), string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the system name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the localized name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; set; }

    }
}
