// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaginatedResult.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the PaginatedResult type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    /// <summary>
    /// The paginated result.
    /// </summary>
    public abstract class PaginatedResult
    {
        /// <summary>
        /// Gets or sets the pagination.
        /// </summary>
        public Pagination Pagination { get; set; }
    }
}