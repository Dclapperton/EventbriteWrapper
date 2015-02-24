// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the HtmlString type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using TestingEventBriteApi.Infrastructure;
    using TestingEventBriteApi.Infrastructure.CsvExport;

    /// <summary>
    /// The html string.
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [NonCsvProperty]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the html.
        /// </summary>
        [CsvProperty("Value")]
        public string Html { get; set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.Html;
        }
    }
}