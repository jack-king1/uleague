using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace APIProject.Services
{
    public class RiotAPIService
    {
        private string localDir = "E:/RiotImages/";
        private string url = "http://ddragon.leagueoflegends.com/cdn/";

        private HttpClient _httpClient;

        private string riotAPIKey = "RGAPI-73f1313c-f338-4dcf-af5f-8b33dc2ef73d";


        public RiotAPIService()
        {
            _httpClient = new HttpClient();
            //Get global data for riot api such as summoner spells and rune data

        }

        //Get all league champion data.
        public async Task<dynamic> GetAllChampionDataAsync(string currentPatch, string region = "en_GB")
        {
            try
            {

                string apiUrl = $"{url}{currentPatch}/data/{region}/champion.json"; // Replace with your API URL
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


        public async Task<dynamic> GetChampionDataAsync(string name, string currentPatch, string region = "en_GB")
        {
            try
            {

                string apiUrl = $"{url}{currentPatch}/data/{region}/champion/{name}.json"; // Replace with your API URL
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

        public async Task<dynamic> GetSummonerMatchHistoryListByPuuid(string puuid, int count = 10, string region = "europe")
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

        public async Task<dynamic> GetSummonerSpellDataASync(string currentPatch, string region = "en_GB")
        {
            string apiUrl = $"http://ddragon.leagueoflegends.com/cdn/{currentPatch}/data/{region}/summoner.json";

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

        public async Task<dynamic> GetRuneDataASync(string currentPatch, string region = "en_GB")
        {
            string apiUrl = $"http://ddragon.leagueoflegends.com/cdn/{currentPatch}/data/{region}/runesReforged.json";

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

        public async Task<dynamic> GetMatchTypeDataASync()
        {
            string apiUrl = $"https://static.developer.riotgames.com/docs/lol/queues.json";

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

        //Get league patch version
        public async Task<dynamic> GetPatchVersionsDataASync()
        {
            string apiUrl = $"https://ddragon.leagueoflegends.com/api/versions.json";

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
