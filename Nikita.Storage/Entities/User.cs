// <copyright file="User.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="User" />
    /// </summary>
    public abstract class User : IEntity
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        public string Type => "user";

        /// <summary>
        /// Gets or sets the Salt for SRP
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// Gets or sets the Verifier for SRP
        /// </summary>
        public string Verifier { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedDate
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the Roles
        /// </summary>
        public IEnumerable<string> Roles { get; set; }
    }
}
