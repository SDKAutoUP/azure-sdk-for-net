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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties that are associated with a scalar function.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Scalar")]
    public partial class ScalarFunctionProperties : FunctionProperties
    {
        /// <summary>
        /// Initializes a new instance of the ScalarFunctionProperties class.
        /// </summary>
        public ScalarFunctionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScalarFunctionProperties class.
        /// </summary>
        /// <param name="etag">The current entity tag for the function. This is
        /// an opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.</param>
        public ScalarFunctionProperties(string etag = default(string), IList<FunctionInput> inputs = default(IList<FunctionInput>), FunctionOutput output = default(FunctionOutput), FunctionBinding binding = default(FunctionBinding))
            : base(etag, inputs, output, binding)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
