using System.Text.Json.Serialization;

namespace GymProgress.Domain.Models
{
    public class Seance
    {
        [JsonPropertyName("seanceId")]
        public string SeanceId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("exercices")]
        public List<Exercice> Exercices { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        public Seance()
        {
            Exercices = new List<Exercice>();     
        }

        public Seance(string name, List<Exercice> exercices)
        {
            Name = name;
            Exercices = exercices;
        }
        public Seance(string name, List<Exercice> exercices, DateTime date)
        {
            Name = name;
            Exercices = exercices;
            Date = date;
        }
        public Seance(string name, List<Exercice> exercices, string userId)
        {
            Name = name;
            Exercices = exercices;
            UserId = userId;
        }
        public Seance(string name, List<Exercice> exercices, string userId, DateTime date)
        {
            Name = name;
            Exercices = exercices;
            UserId = userId;
            Date = date;
        }
        public Seance(List<Exercice> exercices)
        {
            Exercices = exercices;
        }
        public Seance(string name)
        {
            Name = name;
        }
        public Seance(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
        public Seance(string name, string userId)
        {
            Name = name;
            UserId = userId;
        }
        public Seance(string name, string userId, DateTime date)
        {
            Name = name;
            UserId = userId;
            Date = date;
        }
    }
}
