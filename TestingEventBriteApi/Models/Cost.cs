// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cost.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The cost.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using TestingEventBriteApi.Infrastructure;

    /// <summary>
    /// The cost.
    /// </summary>
    public class Cost
    {
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [NonCsvProperty]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the gross.
        /// </summary>
        [NonCsvProperty]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value { get; set; }
    }
}