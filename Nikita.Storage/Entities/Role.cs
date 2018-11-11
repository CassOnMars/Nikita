// <copyright file="Role.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="Role" />
    /// </summary>
    public abstract class Role : IEntity
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        public string Type => "role";

        /// <summary>
        /// Gets or sets the CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedDate
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
