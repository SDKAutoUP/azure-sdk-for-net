// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DelegatedNetwork
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ControllerOperations operations.
    /// </summary>
    public partial interface IControllerOperations
    {
        /// <summary>
        /// Gets details about the specified dnc controller.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// DelegatedNetwork resource is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource. It must be a minimum of 3 characters, and
        /// a maximum of 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DelegatedController>> GetDetailsWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a dnc controller
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// DelegatedNetwork resource is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource. It must be a minimum of 3 characters, and
        /// a maximum of 63.
        /// </param>
        /// <param name='controllerParameters'>
        /// controller type parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DelegatedController>> CreateWithHttpMessagesAsync(string resourceGroupName, string resourceName, ControllerTypeParameters controllerParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the DNC controller
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// DelegatedNetwork resource is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource. It must be a minimum of 3 characters, and
        /// a maximum of 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update dnc controller
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// DelegatedNetwork resource is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource. It must be a minimum of 3 characters, and
        /// a maximum of 63.
        /// </param>
        /// <param name='controllerParameters'>
        /// controller type parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DelegatedController>> PatchWithHttpMessagesAsync(string resourceGroupName, string resourceName, ControllerTypeParameters controllerParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a dnc controller
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// DelegatedNetwork resource is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource. It must be a minimum of 3 characters, and
        /// a maximum of 63.
        /// </param>
        /// <param name='controllerParameters'>
        /// controller type parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DelegatedController>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string resourceName, ControllerTypeParameters controllerParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the DNC controller
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// DelegatedNetwork resource is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource. It must be a minimum of 3 characters, and
        /// a maximum of 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
