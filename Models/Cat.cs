using System.ComponentModel.DataAnnotations;

namespace LateFall2020CatsApi.Models
{
    public class Cat
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20, ErrorMessage = "You userd too 22 many ledderss and stufszzz!")]
        public string Name { get; set; }
        [Required]
        public string HairColor { get; set; }
        [Required]
        public int Lives { get; set; }
        public Cat(string name, string hairColor, int lives)
        {
            Name = name;
            HairColor = hairColor;
            Lives = lives;
        }
    }
}