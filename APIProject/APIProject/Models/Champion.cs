using APIProject.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace APIProject.Models
{
    public class Champion
    {
        [JsonProperty("id")]
        public string champID { get; set; }
        [JsonProperty("key")]
        public string champKey { get; set; }
        public string champName { get; set; }
        public string title { get; set; }
        [JsonProperty("image")]
        public Image champImages { get; set; }
        [JsonProperty("skins")]
        public Skins champSkins { get; set; }
        [JsonProperty("lore")]
        public string championLore { get; set; }
        [JsonProperty("blurb")]
        public string championBlurb { get; set; }
        public string [] allyTips { get; set; }
        public string[] enemyTips { get; set; } 
        public string[] tags { get; set; }
        public string partype { get; set; }
        public Info info { get; set; }
        public Stats stats { get; set; }


        public async Task<dynamic> GetAllChampionDataFromApi()
        {
            List<Champion> championList = new List<Champion>();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonDataString = await riotAPIService.GetAllChampionData();
            dynamic jsonObj = JsonConvert.DeserializeObject<dynamic>(jsonDataString);
            dynamic jsonChampData = jsonObj.data;

            try
            {
                // ... process the retrieved data as needed ...
                championList = JsonConvert.DeserializeObject<List<Champion>>(jsonChampData);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            // Return the processed data
            return championList;
        }
    }

    public class Image
    {
        [JsonProperty("full")]
        public string fullImage { get; set; }
        [JsonProperty("sprite")]
        public string spriteImage { get; set; }
        [JsonProperty("group")]
        public string groupImage { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Skins
    {
        [JsonProperty("id")]
        public string skinID { get; set; }
        [JsonProperty("num")]
        public int skinNumber { get; set; }
        [JsonProperty("name")]
        public string skinName { get; set; }
        public bool chromas { get; set; }
    }

    public class Info
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
    }

    public class Stats
    {
        public int hp { get; set; }
        public int hpperlevel { get; set; }
        public int mp { get; set; }
        public int mpperlevel { get; set; }
        public int movespeed { get; set; }
        public int armor { get; set; }
        public int armorperlevel { get; set;}
        public int spellblock { get; set; }
        public int spellblockperlevel { get; set; }
        public int attackrange { get; set; }
        public int hpregen { get; set; }
        public int hpregenperlevel { get; set;}
        public int mpregenperlevel { get; set; }
        public int crit { get; set; }
        public int critperlevel { get; set; }
        public int attackdamageperlevel { get; set; }
        public int attackspeedperlevel { get; set; }
        public int attackspeed { get; set; }
    }
}
