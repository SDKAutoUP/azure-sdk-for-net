// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DelegatedNetwork.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An array of Delegated subnets resources.
    /// </summary>
    public partial class DelegatedSubnetList
    {
        /// <summary>
        /// Initializes a new instance of the DelegatedSubnetList class.
        /// </summary>
        public DelegatedSubnetList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelegatedSubnetList class.
        /// </summary>
        /// <param name="value">An array of Delegated subnets
        /// resources.</param>
        public DelegatedSubnetList(IList<DelegatedSubnet> value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of Delegated subnets resources.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<DelegatedSubnet> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
