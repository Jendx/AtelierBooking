using AtelierBooking.Models;
using System.Text.Json;

namespace AtelierBooking.Http
{
    internal sealed class ApiClient : HttpClient
    {
        public ApiClient() 
        {
            client = new HttpClient();

            BaseAddress = new Uri("https://atelier-havirov.cz/api/"); 
        }

        private HttpClient client { get; init; }

        public async Task<List<BookTime>> GetBookTimes()
        {  
            var data = await client.GetAsync("/list");
            JsonSerializer.Deserialize<List<BookTime>>(data);
        }
    }
}
