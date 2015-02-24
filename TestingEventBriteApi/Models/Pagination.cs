// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pagination.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The pagination.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// The pagination.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Gets or sets the object count.
        /// </summary>
        [JsonProperty("object_count")]
        public int ObjectCount { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the page size.
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the page count.
        /// </summary>
        [JsonProperty("page_count")]
        public int PageCount { get; set; }
    }
}