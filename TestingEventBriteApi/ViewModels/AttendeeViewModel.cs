// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AttendeeViewModel.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the AttendeeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.ViewModels
{
    using TestingEventBriteApi.Models;

    /// <summary>
    /// The attendee view model.
    /// </summary>
    public class AttendeeViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeeViewModel"/> class.
        /// </summary>
        /// <param name="attendee">
        /// The attendee.
        /// </param>
        public AttendeeViewModel(Attendee attendee)
        {
            this.Attendee = attendee;
        }

        /// <summary>
        /// Gets or sets the attendee.
        /// </summary>
        public Attendee Attendee { get; set; }
    }
}