// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IDirectoryRoleTemplateRequest.
    /// </summary>
    public partial interface IDirectoryRoleTemplateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryRoleTemplate using PUT.
        /// </summary>
        /// <param name="directoryRoleTemplateToCreate">The DirectoryRoleTemplate to create.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> CreateAsync(DirectoryRoleTemplate directoryRoleTemplateToCreate);        /// <summary>
        /// Creates the specified DirectoryRoleTemplate using PUT.
        /// </summary>
        /// <param name="directoryRoleTemplateToCreate">The DirectoryRoleTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> CreateAsync(DirectoryRoleTemplate directoryRoleTemplateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryRoleTemplate.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectoryRoleTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryRoleTemplate.
        /// </summary>
        /// <returns>The DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryRoleTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryRoleTemplate using PATCH.
        /// </summary>
        /// <param name="directoryRoleTemplateToUpdate">The DirectoryRoleTemplate to update.</param>
        /// <returns>The updated DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> UpdateAsync(DirectoryRoleTemplate directoryRoleTemplateToUpdate);

        /// <summary>
        /// Updates the specified DirectoryRoleTemplate using PATCH.
        /// </summary>
        /// <param name="directoryRoleTemplateToUpdate">The DirectoryRoleTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DirectoryRoleTemplate.</returns>
        Task<DirectoryRoleTemplate> UpdateAsync(DirectoryRoleTemplate directoryRoleTemplateToUpdate, CancellationToken cancellationToken);

    }
}
