using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Samples_Book_Building_WebApp_with_Blazor.Data;

namespace Samples_Book_Building_WebApp_with_Blazor.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private HttpClient HttpClient { get; set; }
        
        public AuthorService(HttpClient httpClient)
        {
            this.HttpClient = httpClient;
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Author>>("/Authors").ConfigureAwait(false);
        }
    }
}
