// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Attendee.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The attendee.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The attendee.
    /// </summary>
    public class Attendee
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the profile.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the changed.
        /// </summary>
        public string Changed { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Gets or sets the answers.
        /// </summary>
        public IEnumerable<Answer> Answers { get; set; }

        /// <summary>
        /// Gets or sets the costs.
        /// </summary>
        public Costs Costs { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public Order Order { get; set; }
    }
}