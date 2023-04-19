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
        [JsonProperty("name")]
        public string champName { get; set; }
        public string title { get; set; }
        [JsonProperty("image")]
        public Image imageData { get; set; }
        [JsonProperty("skins")]
        public List<Skins> champSkins { get; set; }
        public string lore { get; set; }
        public string blurb { get; set; }
        public string [] allytips { get; set; }
        public string[] enemytips { get; set; } 
        public string[] tags { get; set; }
        public string partype { get; set; }
        public Info info { get; set; }
        public Stats stats { get; set; }
        public Spell spells { get; set; }
        public Passive passive { get; set; }
        public List<object> recommended { get; set; }


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
        public string spriteGroup { get; set; }
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
        public int mpregen { get; set; }
        public int mpregenperlevel { get; set; }
        public int crit { get; set; }
        public int critperlevel { get; set; }
        public int attackdamage { get; set; }
        public int attackdamageperlevel { get; set; }
        public int attackspeedperlevel { get; set; }
        public int attackspeed { get; set; }
    }

    public class Spell
    {
        [JsonProperty("id")]
        public string spellID { get; set; }
        [JsonProperty("name")]
        public string spellName { get; set; }
        [JsonProperty("description")]
        public string spellDesc { get; set; }
        public string tooltip { get; set; }
        public LevelTip leveltip { get; set; }

        public int maxrank { get; set; }
        public List<int> cooldown { get; set; }
        public string cooldownburn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public List<object> datavalues { get; set; }

        [JsonProperty("effect")]
        public DataWrapper spellEffect { get; set; }
        public List<object> effectBurn { get; set; }
        public List<object> vars { get; set; }
        public string costType { get; set; }
        public string maxammo { get; set; }
        public List<int> range { get; set; }
        public string rangeBurn { get; set; }
        public Image image { get; set; }

        [JsonProperty("resource")]
        public string spellCost { get; set; }

    }

    public class LevelTip
    {
        public List<string> label { get; set; }
        public List<string> effect { get; set; }
    }

    public class DataWrapper
    { 
        public List<List<object>> data { get; set; }
    }

    public class Passive
    {
        [JsonProperty("name")]
        public string passiveName { get; set; }
        public string description { get; set; }
        public Image image { get; set; }

    }
}
