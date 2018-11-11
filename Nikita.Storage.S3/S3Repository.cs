// <copyright file="S3Repository.cs" author="Dustin R. Heart">
// Copyright (c) 2018 Dustin R. Heart. All rights reserved.
// </copyright>

namespace Nikita.Storage.S3
{
    using Amazon.S3;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="S3Repository{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class S3Repository<T> : IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Defines the _s3Client
        /// </summary>
        private IAmazonS3 _s3Client;

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Repository{T}"/> class.
        /// </summary>
        /// <param name="s3Client">The <see cref="IAmazonS3"/></param>
        public S3Repository(IAmazonS3 s3Client)
        {
            this._s3Client = s3Client;
        }

        /// <summary>
        /// Creates the <see cref="T"/>.
        /// </summary>
        /// <param name="entity">The <see cref="T"/></param>
        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the <see cref="T"/>.
        /// </summary>
        /// <param name="entity">The <see cref="T"/></param>
        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all instances of <see cref="T"/>.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Task{T}}"/></returns>
        public IEnumerable<Task<T>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all metadata for the <see cref="T"/>.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{IEntityMetadata}"/></returns>
        public IEnumerable<Task<IEntityMetadata>> FindAllMetadataAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the <see cref="T"/> by its name.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        public Task<T> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the <see cref="T"/>.
        /// </summary>
        /// <param name="entity">The <see cref="T"/></param>
        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
