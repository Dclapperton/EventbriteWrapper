// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventServices.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The api.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Services
{
    using System.Collections.Generic;
    using System.Configuration;

    using TestingEventBriteApi.Models;
    using TestingEventBriteApi.Models.ServiceModels;

    /// <summary>
    /// The api.
    /// </summary>
    public class EventServices : ServiceBase
    {
        /// <summary>
        /// The get events by user id.
        /// </summary>
        /// <param name="userId">
        /// The user id.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{Event}"/>.
        /// </returns>
        public static IEnumerable<Event> GetEventsByUserId(int userId)
        {
            const string Url = "users/{0}/owned_events/";

            IEnumerable<Event> events = CallApi<IEnumerable<Event>>(string.Format(Url,userId)).Result;

            return events;
        }

        /// <summary>
        /// The get event by id.
        /// </summary>
        /// <param name="eventId">
        /// The event id.
        /// </param>
        /// <returns>
        /// The <see cref="Event"/>.
        /// </returns>
        public static Event GetEventById(string eventId)
        {
            const string Url = "events/{0}/";

            Event eventDetails = CallApi<Event>(string.Format(Url, eventId)).Result;

            return eventDetails;
        }

        /// <summary>
        /// The get my events.
        /// </summary>
        /// <returns>
        /// The <see cref="PagedOwnedEvents"/>.
        /// </returns>
        public static PagedOwnedEvents GetMyEvents()
        {
            const string Url = "users/{0}/owned_events/";

            PagedOwnedEvents events = CallApi<PagedOwnedEvents>(string.Format(Url, ConfigurationManager.AppSettings["EventBriteUserId"])).Result;

            return events;
        }

        /// <summary>
        /// The get questions by event id.
        /// </summary>
        /// <param name="eventId">
        /// The event id.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{Questions}"/>.
        /// </returns>
        public static IEnumerable<Question> GetQuestionsByEventId(string eventId)
        {
            const string Url = "events/{0}/questions/";

            IEnumerable<Question> questions = CallApi<IEnumerable<Question>>(string.Format(Url, ConfigurationManager.AppSettings["EventBriteUserId"])).Result;

            return questions;
        }
    }
}