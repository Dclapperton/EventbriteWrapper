// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CsvProperty.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the CsvProperty type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Infrastructure.CsvExport
{
    using System;

    /// <summary>
    /// The csv property.
    /// </summary>
    public class CsvProperty : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvProperty"/> class.
        /// </summary>
        /// <param name="name">
        /// The field name displayed in the export.
        /// </param>
        public CsvProperty(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the header name.
        /// </summary>
        public string Name { get; set; }
    }
}