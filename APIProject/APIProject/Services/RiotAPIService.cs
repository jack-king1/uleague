using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace APIProject.Services
{
    public class RiotAPIService
    {
        private HttpClient _httpClient;

        public RiotAPIService()
        {
            _httpClient = new HttpClient();
        }

        //Get all league champion data.
        public async Task<dynamic> GetAllChampionData()
        {
            try
            {
                string apiUrl = "http://ddragon.leagueoflegends.com/cdn/13.8.1/data/en_US/champion.json"; // Replace with your API URL
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Throw an exception if response is not successful

                //json string which can be converted into c# object using deserialization.
                string json = await response.Content.ReadAsStringAsync();
                
                return json;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public async Task<dynamic> GetChampionData(string name)
        {
            try
            {
                string apiUrl = $"http://ddragon.leagueoflegends.com/cdn/13.8.1/data/en_US/champion/{name}.json"; // Replace with your API URL
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Throw an exception if response is not successful

                string json = await response.Content.ReadAsStringAsync();
                return json;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
