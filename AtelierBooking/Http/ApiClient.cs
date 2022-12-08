using AtelierBooking.Models;
using AtelierBooking.Models.ApiModels;
using System.Text;
using System.Text.Json;

namespace AtelierBooking.Http
{
    internal sealed class ApiClient : HttpClient
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        };

        public ApiClient() 
        {
            client = new HttpClient();
            client.BaseAddress = Security.addres; 
        }

        private HttpClient client { get; init; }

        public async Task<IEnumerable<ReservationsAPIData>> GetBookTimes()
        {
            var content = new StringContent(Security.GetCredentials(), Encoding.UTF8, "application/json");

            using var result = await client.PostAsync("list", content);

            if(result.IsSuccessStatusCode)
            {
                var apiReservations = await JsonSerializer.DeserializeAsync<ReservationsWraper>(await result.Content.ReadAsStreamAsync(), _jsonSerializerOptions);
                return apiReservations.Reservations;
            }

            throw new Exception(result.StatusCode.ToString());
        }
    }

    class ReservationsWraper
    {
        public List<ReservationsAPIData> Reservations { get; set; }
    }
}
