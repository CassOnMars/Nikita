// <copyright file="Author.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="Author" />
    /// </summary>
    public abstract class Author : IEntity
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        public string Type => "author";

        /// <summary>
        /// Gets or sets the Full Name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the Author data
        /// </summary>
        public string AuthorData { get; set; }

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
