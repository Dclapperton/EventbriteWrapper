// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Event.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the Event type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    /// <summary>
    /// The event.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public Content Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public Content Description { get; set; }

        /// <summary>
        /// Gets or sets the capacity.
        /// </summary>
        public int Capacity { get; set; }
    }
}