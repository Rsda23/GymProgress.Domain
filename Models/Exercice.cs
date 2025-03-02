using System.Text.Json.Serialization;

namespace GymProgress.Domain.Models
{
    public class Exercice
    {
        [JsonPropertyName("exerciceId")]
        public string ExerciceId { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string Nom { get; set; }
        [JsonPropertyName("repetition")]
        public int Repetition { get; set; }
        [JsonPropertyName("serie")]
        public int Serie { get; set; }
        [JsonPropertyName("charge")]
        public float Charge { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        public Exercice()
        {
        
        }
        public Exercice(string nom, int repetition, int serie, float charge, DateTime date, string userId)
        {
            Nom = nom;
            Repetition = repetition;
            Serie = serie;
            Charge = charge;
            Date = date;
            UserId = userId;
        }
    }
}
