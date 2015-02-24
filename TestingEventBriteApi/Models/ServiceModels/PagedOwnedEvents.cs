// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OwnedEvents.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The owned events.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models.ServiceModels
{
    using System.Collections.Generic;

    /// <summary>
    /// The owned events.
    /// </summary>
    public class PagedOwnedEvents : PaginatedResult
    {
        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        public IEnumerable<Event> Events { get; set; }
    }
}