// <copyright file="IEntityMetadata.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage
{
    using System;

    /// <summary>
    /// Defines the <see cref="IEntityMetadata" />
    /// </summary>
    public interface IEntityMetadata
    {
        /// <summary>
        /// Gets the Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Gets the Author
        /// </summary>
        string Author { get; }

        /// <summary>
        /// Gets the LastModified
        /// </summary>
        DateTime LastModified { get; }
    }
}
