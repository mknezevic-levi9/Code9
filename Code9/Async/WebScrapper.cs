﻿using System.Net;
using System.Threading.Tasks;

namespace Async
{
    /// <summary>
    /// Retrieves and extracts content of web pages.
    /// </summary>
    public class WebScrapper
    {
        /// <summary>
        /// Gets the content of the passed url.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public string GetPageContent(string url)
        {
            using (var client = new WebClient())
            {
                string result = client.DownloadString(url);
                return result;
            }
        }

        /// <summary>
        /// Gets the content of the passed url.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public async Task<string> GetPageContentAsync(string url)
        {
            using (var client = new WebClient())
            {
                string result = await client.DownloadStringTaskAsync(url);

                return result;
            }
        }
    }
}
