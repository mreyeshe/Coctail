using Microsoft.AspNetCore.WebUtilities;
using Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MockService
{
    public abstract class RepositoryMockService<T> where T : class
    {
        protected string _urlService;

        private Uri uriRequest;

        public async Task<T> GetAsync(Dictionary<string, string> parameters)
        {
            try
            {
                uriRequest = new Uri(QueryHelpers.AddQueryString(_urlService, parameters));

                var jsonResponse = await GetStringAsync();

                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
            catch (Exception ex)
            {
                return JsonConvert.DeserializeObject<T>("");
            }
        }

        protected async Task<string> GetStringAsync()
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(uriRequest);
            }
        }
    }
}
