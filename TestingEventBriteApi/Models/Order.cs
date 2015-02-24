// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Order.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the Order type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    /// <summary>
    /// The order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the changed.
        /// </summary>
        public string Changed { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Gets or sets the costs.
        /// </summary>
        public Costs Costs { get; set; }
    }
}