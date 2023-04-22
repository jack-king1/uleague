using APIProject.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.ObjectPool;

namespace APIProject.Models
{
    public class Champion
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }

        public Info info { get; set; }
        public Image image { get; set; }
        public string[] tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class ChampionDetail
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
        public List<Skin> skins { get; set; }
        public string lore { get; set; }
        public string blurb { get; set; }
        public List<string> allytips { get; set; }
        public List<string> enemytips { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Info info { get; set; }
        public Stats stats { get; set; }
        public List<Spell> spells { get; set; }
        public Passive passive { get; set; }
        public List<object>? recommended { get; set; }

    }

    public class ChampionAPI
    {
        public async Task<dynamic> GetAllChampionDataFromApiAsync()
        {
            Dictionary<string, Champion> champions = new Dictionary<string, Champion>();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonDataString = await riotAPIService.GetAllChampionDataAsync();

            try
            {
                // ... process the retrieved data as needed ...
                champions = JObject.Parse(jsonDataString)["data"].ToObject<Dictionary<string, Champion>>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            // Return the processed data
            return champions;
        }

        public async Task<dynamic> GetChampionDataFromApiAsync(string champName)
        {
            Dictionary<string, ChampionDetail> champion = new Dictionary<string, ChampionDetail>();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonDataString = await riotAPIService.GetChampionDataAsync(champName);

            try
            {
                // ... process the retrieved data as needed ...
                champion = JObject.Parse(jsonDataString)["data"].ToObject<Dictionary<string, ChampionDetail>>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            // Return the processed data
            return champion;
        }
    }

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int? x { get; set; }
        public int? y { get; set; }
        public int? w { get; set; }
        public int? h { get; set; }
    }

    public class Skin
    {
        public string id { get; set; }
        public int? num { get; set; }
        public string name { get; set; }
        public bool? chromas { get; set; }
    }

    public class Info
    {
        public int? attack { get; set; }
        public int? defense { get; set; }
        public int? magic { get; set; }
        public int? difficulty { get; set; }
    }

    public class Stats
    {
        public int? hp { get; set; }
        public int? hpperlevel { get; set; }
        public int? mp { get; set; }
        public int? mpperlevel { get; set; }
        public int? movespeed { get; set; }
        public int? armor { get; set; }
        public double? armorperlevel { get; set; }
        public int? spellblock { get; set; }
        public double? spellblockperlevel { get; set; }
        public int? attackrange { get; set; }
        public int? hpregen { get; set; }
        public int? hpregenperlevel { get; set; }
        public int? mpregen { get; set; }
        public int? mpregenperlevel { get; set; }
        public int? crit { get; set; }
        public int? critperlevel { get; set; }
        public int? attackdamage { get; set; }
        public int? attackdamageperlevel { get; set; }
        public double? attackspeedperlevel { get; set; }
        public double? attackspeed { get; set; }
    }

    public class Spell
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public Leveltip leveltip { get; set; }
        public int? maxrank { get; set; }
        public List<int?> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int?> cost { get; set; }
        public string costBurn { get; set; }
        public Datavalues datavalues { get; set; }
        public List<List<int?>> effect { get; set; }
        public List<string?>? effectBurn { get; set; }
        public List<object> vars { get; set; }
        public string costType { get; set; }
        public string maxammo { get; set; }
        public List<int?> range { get; set; }
        public string rangeBurn { get; set; }
        public Image image { get; set; }
        public string resource { get; set; }
    }
    public class Datavalues
    {
    }
    public class Leveltip
    {
        public List<string> label { get; set; }
        public List<string> effect { get; set; }
    }

    public class Passive
    {
        public string name { get; set; }
        public string description { get; set; }
        public Image image { get; set; }
    }
}
