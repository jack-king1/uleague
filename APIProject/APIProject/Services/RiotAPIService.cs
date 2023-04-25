using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace APIProject.Services
{
    public class RiotAPIService
    {
        private string localDir = "E:/RiotImages/";

        private HttpClient _httpClient;

        private string riotAPIKey = "RGAPI-6f1b48e3-dcdb-4cb3-8457-89c0b00725bd";

        public RiotAPIService()
        {
            _httpClient = new HttpClient();
            //Get global data for riot api such as summoner spells and rune data

        }

        //Get all league champion data.
        public async Task<dynamic> GetAllChampionDataAsync()
        {
            //try
            //{
                
            //    string apiUrl = $"{localDir}13.8.1/data/en_GB/champion.json"; // Replace with your API URL
            //    HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            //    response.EnsureSuccessStatusCode(); // Throw an exception if response is not successful

            //    //json string which can be converted into c# object using deserialization.
            //    string json = await response.Content.ReadAsStringAsync();
            //    return json;
            //}
            //catch (Exception ex)
            //{
            //    // Handle any exceptions
            //    Console.WriteLine($"Error: {ex.Message}");
            //    return null;
            //}

            try
            {

                string apiUrl = $"{localDir}13.8.1/data/en_GB/champion.json"; // Replace with your API URL
                using (StreamReader reader = new StreamReader(apiUrl))
                {
                    string json = reader.ReadToEndAsync().Result; // Read the entire file content as a string
                    //MyObject myObject = JsonConvert.DeserializeObject<MyObject>(json); // Deserialize the JSON string into an object
                    // Do something with the deserialized object (e.g., bind it to a data source, display it in UI, etc.)
                    return json;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }


        public async Task<dynamic> GetChampionDataAsync(string name)
        {
            try
            {
               string apiUrl = $"{localDir}13.8.1/data/en_GB/champion/{name}.json"; // Replace with your API URL
               using (StreamReader reader = new StreamReader(apiUrl))
                {
                    string json = reader.ReadToEndAsync().Result; // Read the entire file content as a string
                    //MyObject myObject = JsonConvert.DeserializeObject<MyObject>(json); // Deserialize the JSON string into an object
                    // Do something with the deserialized object (e.g., bind it to a data source, display it in UI, etc.)
                    return json;
                }

            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<dynamic> GetSummonerDataByName(string name, string region = "euw1")
        {

            string apiUrl = $"https://{region}.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}?api_key={riotAPIKey}"; // Replace with your API URL

            try
            {

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

        public async Task<dynamic> GetSummonerMatchHistoryListByPuuid(string puuid, int count = 2, string region = "europe")
        {

            string apiUrl = $"https://{region}.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuid}/ids?start=0&count={count}&api_key={riotAPIKey}"; // Replace with your API URL

            try
            {

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

        public async Task<dynamic> GetSummonerMatchDataByMatchID(string matchID, string region = "europe")
        {

            string apiUrl = $"https://{region}.api.riotgames.com/lol/match/v5/matches/{matchID}?api_key={riotAPIKey}"; // Replace with your API URL

            try
            {

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

        public async Task<dynamic> GetSummonerSpellDataASync(string region = "en_GB")
        {
            string apiUrl = $"http://ddragon.leagueoflegends.com/cdn/13.8.1/data/{region}/summoner.json";

            try
            {
                // Fetch JSON data from URL
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

        public async Task<dynamic> GetRuneDataASync(string region = "en_GB")
        {
            string apiUrl = $"http://ddragon.leagueoflegends.com/cdn/13.8.1/data/{region}/runesReforged.json";

            try
            {
                // Fetch JSON data from URL
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


    }
}
