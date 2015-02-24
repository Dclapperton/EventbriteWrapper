// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExportable.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the IExportable type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Interfaces
{
    using System.Linq.Expressions;

    /// <summary>
    /// The Exportable interface.
    /// </summary>
    public interface IExportable
    {
        /// <summary>
        /// Gets the expression.
        /// </summary>
        Expression Expression { get; }
    }
}