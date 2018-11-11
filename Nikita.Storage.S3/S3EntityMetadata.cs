// <copyright file="S3EntityMetadata.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.S3
{
    using System;

    /// <summary>
    /// Defines the <see cref="S3EntityMetadata" />
    /// </summary>
    public class S3EntityMetadata : IEntityMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3EntityMetadata"/> class.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <param name="type">The <see cref="string"/></param>
        /// <param name="author">The <see cref="string"/></param>
        /// <param name="lastModified">The <see cref="DateTime"/></param>
        public S3EntityMetadata(string name, string type, string author, DateTime lastModified)
        {
            this.Name = name;
            this.Type = type;
            this.Author = author;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets the Author
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// Gets the LastModified
        /// </summary>
        public DateTime LastModified { get; private set; }
    }
}
