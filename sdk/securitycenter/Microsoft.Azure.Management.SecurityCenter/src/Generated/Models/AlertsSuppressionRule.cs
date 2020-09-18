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
    /// Describes the suppression rule
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AlertsSuppressionRule : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AlertsSuppressionRule class.
        /// </summary>
        public AlertsSuppressionRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertsSuppressionRule class.
        /// </summary>
        /// <param name="alertType">Type of the alert to automatically
        /// suppress. For all alert types, use '*'</param>
        /// <param name="reason">The reason for dismissing the alert</param>
        /// <param name="state">Possible states of the rule. Possible values
        /// include: 'Enabled', 'Disabled', 'Expired'</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="lastModifiedUtc">The last time this rule was
        /// modified</param>
        /// <param name="expirationDateUtc">Expiration date of the rule, if
        /// value is not provided or provided as null this field will default
        /// to the maximum allowed expiration date.</param>
        /// <param name="comment">Any comment regarding the rule</param>
        /// <param name="suppressionAlertsScope">The suppression
        /// conditions</param>
        public AlertsSuppressionRule(string alertType, string reason, RuleState state, string id = default(string), string name = default(string), string type = default(string), System.DateTime? lastModifiedUtc = default(System.DateTime?), System.DateTime? expirationDateUtc = default(System.DateTime?), string comment = default(string), SuppressionAlertsScope suppressionAlertsScope = default(SuppressionAlertsScope))
            : base(id, name, type)
        {
            AlertType = alertType;
            LastModifiedUtc = lastModifiedUtc;
            ExpirationDateUtc = expirationDateUtc;
            Reason = reason;
            State = state;
            Comment = comment;
            SuppressionAlertsScope = suppressionAlertsScope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the alert to automatically suppress. For all
        /// alert types, use '*'
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertType")]
        public string AlertType { get; set; }

        /// <summary>
        /// Gets the last time this rule was modified
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedUtc")]
        public System.DateTime? LastModifiedUtc { get; private set; }

        /// <summary>
        /// Gets or sets expiration date of the rule, if value is not provided
        /// or provided as null this field will default to the maximum allowed
        /// expiration date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDateUtc")]
        public System.DateTime? ExpirationDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the reason for dismissing the alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets possible states of the rule. Possible values include:
        /// 'Enabled', 'Disabled', 'Expired'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public RuleState State { get; set; }

        /// <summary>
        /// Gets or sets any comment regarding the rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the suppression conditions
        /// </summary>
        [JsonProperty(PropertyName = "properties.suppressionAlertsScope")]
        public SuppressionAlertsScope SuppressionAlertsScope { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AlertType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AlertType");
            }
            if (Reason == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Reason");
            }
            if (SuppressionAlertsScope != null)
            {
                SuppressionAlertsScope.Validate();
            }
        }
    }
}
