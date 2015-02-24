// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AttendeesService.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the AttendeesService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Services
{
    using System.Collections.Generic;

    using TestingEventBriteApi.Models;
    using TestingEventBriteApi.Models.ServiceModels;

    /// <summary>
    /// The attendees service.
    /// </summary>
    public class AttendeesService : ServiceBase
    {
        /// <summary>
        /// The get attendees by event id.
        /// </summary>
        /// <param name="eventId">
        /// The event id.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{T}"/>.
        /// </returns>
        public static PagedAttendees GetAttendeesByEventId(string eventId)
        {
            const string Url = "events/{0}/attendees/";

            PagedAttendees attendees = CallApi<PagedAttendees>(string.Format(Url, eventId)).Result;

            return attendees;
        }

        /// <summary>
        /// The get attendee details by id.
        /// </summary>
        /// <param name="eventId">
        /// The event id.
        /// </param>
        /// <param name="attendeeId">
        /// The attendee id.
        /// </param>
        /// <returns>
        /// The <see cref="Attendee"/>.
        /// </returns>
        public static Attendee GetAttendeeDetailsByEventsIdAndAttendeeId(string eventId, string attendeeId)
        {
            const string Url = "events/{0}/attendees/{1}/";

            Attendee attendee = CallApi<Attendee>(string.Format(Url, eventId, attendeeId)).Result;

            return attendee;
        }
    }
}