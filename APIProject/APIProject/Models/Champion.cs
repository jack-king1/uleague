using System.ComponentModel.DataAnnotations;
namespace APIProject.Models

{
    public class Champion
    {
        public int ChampionId { get; set; }
        public string championName { get; set; }
        public string championImage { get; set; }


        //Constructor
        public Champion() {
            ChampionId = -1;
            championName = string.Empty;
            championImage = string.Empty;   

        }

        public Champion(int id, string name, string image = "")
        {
            ChampionId = id;
            championName = name;
            championImage = image;

        }
    }
}
