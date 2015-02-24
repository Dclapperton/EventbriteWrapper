// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceBase.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the ServiceBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Services
{
    using System;
    using System.Configuration;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    /// <summary>
    /// The service base.
    /// </summary>
    public abstract class ServiceBase
    {
        /// <summary>
        /// The api call.
        /// </summary>
        /// <param name="url">
        /// The url to call.
        /// </param>
        /// <typeparam name="T">
        /// The object to return
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task{TResult}"/>.
        /// </returns>
        protected static async Task<T> CallApi<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.eventbriteapi.com/v3/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                const string UrlFormat = "{0}?token={1}";

                url = string.Format(UrlFormat, url, ConfigurationManager.AppSettings["ApiToken"]);

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    T item = await response.Content.ReadAsAsync<T>();
                    return item;
                }

                return (T)Convert.ChangeType(null, typeof(T));
            }
        }
    }
}