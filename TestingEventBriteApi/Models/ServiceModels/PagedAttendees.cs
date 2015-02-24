// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PagedAttendees.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The atendees.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models.ServiceModels
{
    using System.Collections.Generic;

    /// <summary>
    /// The atendees.
    /// </summary>
    public class PagedAttendees : PaginatedResult
    {
        /// <summary>
        /// Gets or sets the attendees.
        /// </summary>
        public IEnumerable<Attendee> Attendees { get; set; }
    }
}