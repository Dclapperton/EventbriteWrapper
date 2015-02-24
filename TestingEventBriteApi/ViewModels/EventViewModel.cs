// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventViewModel.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The event view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.ViewModels
{
    using TestingEventBriteApi.Models;
    using TestingEventBriteApi.Models.ServiceModels;

    /// <summary>
    /// The event view model.
    /// </summary>
    public class EventViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventViewModel"/> class.
        /// </summary>
        /// <param name="event">
        /// The event.
        /// </param>
        /// <param name="attendees">
        /// The attendees.
        /// </param>
        public EventViewModel(Event @event, PagedAttendees attendees)
        {
            this.Event = @event;
            this.PagedAttendees = attendees;
        }

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Gets or sets the attendees.
        /// </summary>
        public PagedAttendees PagedAttendees { get; set; }
    }
}