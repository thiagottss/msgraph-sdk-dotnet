// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IGraphServiceDirectoryRoleTemplatesCollectionRequest.
    /// </summary>
    public partial interface IGraphServiceDirectoryRoleTemplatesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DirectoryRoleTemplate to the collection via POST.
        /// </summary>
        /// <param name="directoryRoleTemplate">The DirectoryRoleTemplate to add.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> AddAsync(DirectoryRoleTemplate directoryRoleTemplate);

        /// <summary>
        /// Adds the specified DirectoryRoleTemplate to the collection via POST.
        /// </summary>
        /// <param name="directoryRoleTemplate">The DirectoryRoleTemplate to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> AddAsync(DirectoryRoleTemplate directoryRoleTemplate, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        Task<IGraphServiceDirectoryRoleTemplatesCollectionPage> GetAsync();
        
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        Task<IGraphServiceDirectoryRoleTemplatesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceDirectoryRoleTemplatesCollectionRequest OrderBy(string value);
    }
}
