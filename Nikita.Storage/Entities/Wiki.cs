// <copyright file="Wiki.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="Wiki" />
    /// </summary>
    public abstract class Wiki : IEntity
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        public string Type => "wiki";

        /// <summary>
        /// Gets or sets the Author Name
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the Editor Name
        /// </summary>
        public string EditorName { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Title change data
        /// </summary>
        public dynamic TitleChange { get; set; }

        /// <summary>
        /// Gets or sets the Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the Content change data
        /// </summary>
        public dynamic ContentChange { get; set; }

        /// <summary>
        /// Gets or sets the Changelog line
        /// </summary>
        public string ChangeLog { get; set; }

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
