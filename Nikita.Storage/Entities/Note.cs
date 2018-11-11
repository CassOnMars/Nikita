// <copyright file="Note.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="Note" />
    /// </summary>
    public abstract class Note : IEntity
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        public string Type => "note";

        /// <summary>
        /// Gets or sets the Author Name
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
