// <copyright file="IRepository.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IRepository{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Finds the <see cref="T"/> by its name.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        Task<T> FindByNameAsync(string name);

        /// <summary>
        /// Creates the <see cref="T"/>.
        /// </summary>
        /// <param name="entity">The <see cref="T"/></param>
        Task CreateAsync(T entity);

        /// <summary>
        /// Updates the <see cref="T"/>.
        /// </summary>
        /// <param name="entity">The <see cref="T"/></param>
        Task UpdateAsync(T entity);

        /// <summary>
        /// Deletes the <see cref="T"/>.
        /// </summary>
        /// <param name="entity">The <see cref="T"/></param>
        Task DeleteAsync(T entity);

        /// <summary>
        /// Retrieves all instances of <see cref="T"/>.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Task{T}}"/></returns>
        IEnumerable<Task<T>> FindAllAsync();

        /// <summary>
        /// Retrieves all metadata for the <see cref="T"/>.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{IEntityMetadata}"/></returns>
        IEnumerable<Task<IEntityMetadata>> FindAllMetadataAsync();
    }
}
