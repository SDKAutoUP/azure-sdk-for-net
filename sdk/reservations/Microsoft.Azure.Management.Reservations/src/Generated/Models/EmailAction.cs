// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Email Action.
    /// </summary>
    public partial class EmailAction
    {
        /// <summary>
        /// Initializes a new instance of the EmailAction class.
        /// </summary>
        public EmailAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailAction class.
        /// </summary>
        /// <param name="emailAddress">The email address for the
        /// action.</param>
        public EmailAction(string emailAddress = default(string))
        {
            EmailAddress = emailAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email address for the action.
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

    }
}
