// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type InferenceClassificationOverridesCollectionRequestBuilder.
    /// </summary>
    public partial class InferenceClassificationOverridesCollectionRequestBuilder : BaseRequestBuilder, IInferenceClassificationOverridesCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new InferenceClassificationOverridesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public InferenceClassificationOverridesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IInferenceClassificationOverridesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IInferenceClassificationOverridesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new InferenceClassificationOverridesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IInferenceClassificationOverrideRequestBuilder"/> for the specified InferenceClassificationInferenceClassificationOverride.
        /// </summary>
        /// <param name="id">The ID for the InferenceClassificationInferenceClassificationOverride.</param>
        /// <returns>The <see cref="IInferenceClassificationOverrideRequestBuilder"/>.</returns>
        public IInferenceClassificationOverrideRequestBuilder this[string id]
        {
            get
            {
                return new InferenceClassificationOverrideRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
