// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes an Azure Data Lake Store output data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.DataLake/Accounts")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureDataLakeStoreOutputDataSource : OutputDataSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureDataLakeStoreOutputDataSource class.
        /// </summary>
        public AzureDataLakeStoreOutputDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureDataLakeStoreOutputDataSource class.
        /// </summary>
        /// <param name="refreshToken">A refresh token that can be used to
        /// obtain a valid access token that can then be used to authenticate
        /// with the data source. A valid refresh token is currently only
        /// obtainable via the Azure Portal. It is recommended to put a dummy
        /// string value here when creating the data source and then going to
        /// the Azure Portal to authenticate the data source which will update
        /// this property with a valid refresh token. Required on PUT
        /// (CreateOrReplace) requests.</param>
        /// <param name="tokenUserPrincipalName">The user principal name (UPN)
        /// of the user that was used to obtain the refresh token. Use this
        /// property to help remember which user was used to obtain the refresh
        /// token.</param>
        /// <param name="tokenUserDisplayName">The user display name of the
        /// user that was used to obtain the refresh token. Use this property
        /// to help remember which user was used to obtain the refresh
        /// token.</param>
        /// <param name="accountName">The name of the Azure Data Lake Store
        /// account. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="tenantId">The tenant id of the user used to obtain the
        /// refresh token. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="filePathPrefix">The location of the file to which the
        /// output should be written to. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="dateFormat">The date format. Wherever {date} appears
        /// in filePathPrefix, the value of this property is used as the date
        /// format instead.</param>
        /// <param name="timeFormat">The time format. Wherever {time} appears
        /// in filePathPrefix, the value of this property is used as the time
        /// format instead.</param>
        /// <param name="authenticationMode">Authentication Mode. Possible
        /// values include: 'Msi', 'UserToken', 'ConnectionString'</param>
        public AzureDataLakeStoreOutputDataSource(string refreshToken = default(string), string tokenUserPrincipalName = default(string), string tokenUserDisplayName = default(string), string accountName = default(string), string tenantId = default(string), string filePathPrefix = default(string), string dateFormat = default(string), string timeFormat = default(string), string authenticationMode = default(string))
        {
            RefreshToken = refreshToken;
            TokenUserPrincipalName = tokenUserPrincipalName;
            TokenUserDisplayName = tokenUserDisplayName;
            AccountName = accountName;
            TenantId = tenantId;
            FilePathPrefix = filePathPrefix;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            AuthenticationMode = authenticationMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a refresh token that can be used to obtain a valid
        /// access token that can then be used to authenticate with the data
        /// source. A valid refresh token is currently only obtainable via the
        /// Azure Portal. It is recommended to put a dummy string value here
        /// when creating the data source and then going to the Azure Portal to
        /// authenticate the data source which will update this property with a
        /// valid refresh token. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the user principal name (UPN) of the user that was
        /// used to obtain the refresh token. Use this property to help
        /// remember which user was used to obtain the refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenUserPrincipalName")]
        public string TokenUserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the user display name of the user that was used to
        /// obtain the refresh token. Use this property to help remember which
        /// user was used to obtain the refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenUserDisplayName")]
        public string TokenUserDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name of the Azure Data Lake Store account.
        /// Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the tenant id of the user used to obtain the refresh
        /// token. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the location of the file to which the output should be
        /// written to. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filePathPrefix")]
        public string FilePathPrefix { get; set; }

        /// <summary>
        /// Gets or sets the date format. Wherever {date} appears in
        /// filePathPrefix, the value of this property is used as the date
        /// format instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dateFormat")]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or sets the time format. Wherever {time} appears in
        /// filePathPrefix, the value of this property is used as the time
        /// format instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeFormat")]
        public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or sets authentication Mode. Possible values include: 'Msi',
        /// 'UserToken', 'ConnectionString'
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationMode")]
        public string AuthenticationMode { get; set; }

    }
}
