// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> This operation retrieves a list of routes the virtual network gateway is advertising to the specified peer. </summary>
    public partial class VirtualNetworkGatewaysGetAdvertisedRoutesOperation : Operation<GatewayRouteListResult>, IOperationSource<GatewayRouteListResult>
    {
        private readonly ArmOperationHelpers<GatewayRouteListResult> _operation;
        internal VirtualNetworkGatewaysGetAdvertisedRoutesOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<GatewayRouteListResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualNetworkGatewaysGetAdvertisedRoutesOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override GatewayRouteListResult Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GatewayRouteListResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GatewayRouteListResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        GatewayRouteListResult IOperationSource<GatewayRouteListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return GatewayRouteListResult.DeserializeGatewayRouteListResult(document.RootElement);
        }

        async ValueTask<GatewayRouteListResult> IOperationSource<GatewayRouteListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return GatewayRouteListResult.DeserializeGatewayRouteListResult(document.RootElement);
        }
    }
}
