// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type ThumbnailSetRequest.
    /// </summary>
    public partial class ThumbnailSetRequest : BaseRequest, IThumbnailSetRequest
    {
        /// <summary>
        /// Constructs a new ThumbnailSetRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ThumbnailSetRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ThumbnailSet using PUT.
        /// </summary>
        /// <param name="thumbnailSetToCreate">The ThumbnailSet to create.</param>
        /// <returns>The created ThumbnailSet.</returns>
        public Task<ThumbnailSet> CreateAsync(ThumbnailSet thumbnailSetToCreate)
        {
            return this.CreateAsync(thumbnailSetToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ThumbnailSet using PUT.
        /// </summary>
        /// <param name="thumbnailSetToCreate">The ThumbnailSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ThumbnailSet.</returns>
        public async Task<ThumbnailSet> CreateAsync(ThumbnailSet thumbnailSetToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<ThumbnailSet>(thumbnailSetToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ThumbnailSet.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ThumbnailSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ThumbnailSet>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ThumbnailSet.
        /// </summary>
        /// <returns>The ThumbnailSet.</returns>
        public Task<ThumbnailSet> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ThumbnailSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ThumbnailSet.</returns>
        public async Task<ThumbnailSet> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ThumbnailSet>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH.
        /// </summary>
        /// <param name="thumbnailSetToUpdate">The ThumbnailSet to update.</param>
        /// <returns>The updated ThumbnailSet.</returns>
        public Task<ThumbnailSet> UpdateAsync(ThumbnailSet thumbnailSetToUpdate)
        {
            return this.UpdateAsync(thumbnailSetToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH.
        /// </summary>
        /// <param name="thumbnailSetToUpdate">The ThumbnailSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ThumbnailSet.</returns>
        public async Task<ThumbnailSet> UpdateAsync(ThumbnailSet thumbnailSetToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ThumbnailSet>(thumbnailSetToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IThumbnailSetRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IThumbnailSetRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="thumbnailSetToInitialize">The <see cref="ThumbnailSet"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ThumbnailSet thumbnailSetToInitialize)
        {

        }
    }
}
