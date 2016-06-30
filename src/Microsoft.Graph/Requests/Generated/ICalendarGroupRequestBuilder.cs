// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICalendarGroupRequestBuilder.
    /// </summary>
    public partial interface ICalendarGroupRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICalendarGroupRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICalendarGroupRequest Request(IEnumerable<Option> options);
        
        /// <summary>
        /// Gets the request builder for Calendars.
        /// </summary>
        /// <returns>The <see cref="ICalendarGroupCalendarsCollectionRequestBuilder"/>.</returns>
        ICalendarGroupCalendarsCollectionRequestBuilder Calendars { get; }
    
    }
}
