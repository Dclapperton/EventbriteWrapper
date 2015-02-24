// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeViewModel.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The home view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.ViewModels
{
    using TestingEventBriteApi.Models.ServiceModels;

    /// <summary>
    /// The home view model.
    /// </summary>
    public class HomeViewModel
    {
        /// <summary>
        /// Gets or sets the my events.
        /// </summary>
        public PagedOwnedEvents MyEvents { get; set; }
    }
}