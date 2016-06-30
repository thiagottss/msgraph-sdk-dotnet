// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DirectoryObjectGetMemberObjectsRequestBody.
    /// </summary>
    [DataContract]
    public partial class DirectoryObjectGetMemberObjectsRequestBody
    {
    
        /// <summary>
        /// Gets or sets SecurityEnabledOnly.
        /// </summary>
        [DataMember(Name = "securityEnabledOnly", EmitDefaultValue = false, IsRequired = false)]
        public bool? SecurityEnabledOnly { get; set; }
    
    }
}
