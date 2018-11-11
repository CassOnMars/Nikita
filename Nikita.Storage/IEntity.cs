// <copyright file="IEntity.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage
{
    /// <summary>
    /// Defines the <see cref="IEntity" />
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the Type
        /// </summary>
        string Type { get; }
    }
}
