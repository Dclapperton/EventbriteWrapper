// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Costs.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The costs.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// The costs.
    /// </summary>
    public class Costs
    {
        /// <summary>
        /// Gets or sets the payment fee.
        /// </summary>
        [JsonProperty("payment_fee")]
        public Cost PaymentFee { get; set; }

        /// <summary>
        /// Gets or sets the gross.
        /// </summary>
        public Cost Gross { get; set; }

        /// <summary>
        /// Gets or sets the eventbrite fee.
        /// </summary>
        [JsonProperty("eventbrite_fee")]
        public Cost EventbriteFee { get; set; }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        public Cost Tax { get; set; }
    }
}