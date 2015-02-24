// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the Question type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The question.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        [JsonProperty("question")]
        public Content ThisQuestion { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets the choices.
        /// </summary>
        public IEnumerable<Answer> Choices { get; set; }

        /// <summary>
        /// Gets or sets the respondent.
        /// </summary>
        public string Respondent { get; set; }

    }
}