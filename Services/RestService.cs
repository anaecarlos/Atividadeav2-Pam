using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using Atividadeav2.Models;

namespace Atividadeav2.Services
{
    internal class RestService
    {
        private HttpClient client;
        private photos photos;
        private List<photos> Photos;
        private JsonSerializerOptions _serializerOptions;

        RestService()
        {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<List<photos>> GetPhotosAsync()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/photos");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Photos = JsonSerializer.Deserialize<List<photos>>(content, _serializerOptions);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Photos;
        }
    }
}


