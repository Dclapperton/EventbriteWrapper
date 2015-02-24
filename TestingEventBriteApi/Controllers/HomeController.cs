// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The home controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using TestingEventBriteApi.Infrastructure;
    using TestingEventBriteApi.Infrastructure.CsvExport;
    using TestingEventBriteApi.Models;
    using TestingEventBriteApi.Models.ServiceModels;
    using TestingEventBriteApi.Services;
    using TestingEventBriteApi.ViewModels;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            PagedOwnedEvents myEvents = EventServices.GetMyEvents();

            HomeViewModel viewModel = new HomeViewModel { MyEvents = myEvents };

            return this.View(viewModel);
        }

        /// <summary>
        /// The details.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param> ©o©a ©ola
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult EventDetails(string id)
        {
            var eventDetails = EventServices.GetEventById(id);

            PagedAttendees attendees = AttendeesService.GetAttendeesByEventId(id);

            EventViewModel viewModel = new EventViewModel(eventDetails, attendees);

            return this.View(viewModel);
        }

        /// <summary>
        /// The attendee details.
        /// </summary>
        /// <param name="attendeeId">
        /// The attendee id.
        /// </param>
        /// <param name="eventId">
        /// The event id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult AttendeeDetails(string attendeeId, string eventId)
        {
            Attendee attendeeDetails = AttendeesService.GetAttendeeDetailsByEventsIdAndAttendeeId(eventId, attendeeId);

            AttendeeViewModel viewModel = new AttendeeViewModel(attendeeDetails);

            return this.View(viewModel);
        }

        /// <summary>
        /// The export events.
        /// </summary>
        /// <returns>
        /// The <see cref="FileResult"/>.
        /// </returns>
        public FileResult ExportEvents()
        {
            PagedOwnedEvents pagedEvents = EventServices.GetMyEvents();

            CsvActionResult<Event> events = new CsvActionResult<Event>(pagedEvents.Events, "my_events.csv");

            return events;
        }

        /// <summary>
        /// The export attendees.
        /// </summary>
        /// <param name="eventId">
        /// The event id.
        /// </param>
        /// <returns>
        /// The <see cref="FileResult"/>.
        /// </returns>
        public FileResult ExportAttendees(string eventId)
        {
            PagedAttendees pagedAttendees = AttendeesService.GetAttendeesByEventId(eventId);

            CsvActionResult<Attendee> attendees = new CsvActionResult<Attendee>(pagedAttendees.Attendees, "attendees.csv");

            return attendees;
        }
    }
}
