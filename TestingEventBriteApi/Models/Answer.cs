// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Answer.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   The answers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// The answer.
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the question id.
        /// </summary>
        [JsonProperty("question_id")]
        public string QuestionId { get; set; }
    }
}