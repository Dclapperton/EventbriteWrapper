// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Profile.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The profile.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// The profile.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }
    }
}