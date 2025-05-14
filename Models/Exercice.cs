using System.Text.Json.Serialization;

namespace GymProgress.Domain.Models
{
    public class Exercice
    {
        [JsonPropertyName("exerciceId")]
        public string ExerciceId { get; set; } = string.Empty;
        [JsonPropertyName("nom")]
        public string Nom { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        [JsonPropertyName("setDatas")]
        public List<SetData> SetDatas { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        public Exercice()
        {
            SetDatas = new List<SetData>();
        }
        public Exercice(string nom)
        {
            Nom = nom;
        }
        public Exercice(string nom, string userId)
        {
            Nom = nom;
            UserId = userId;
        }
        public Exercice(string nom, string userId, DateTime date)
        {
            Nom = nom;
            UserId = userId;
            Date = date;
        }
        public Exercice(string nom, string userId, List<SetData> setDatas)
        {
            Nom = nom;
            UserId = userId;
            SetDatas = setDatas;
        }
        public Exercice(string nom, string userId, List<SetData> setDatas, DateTime date)
        {
            Nom = nom;
            UserId = userId;
            SetDatas = setDatas;
            Date = date;
        }
    }
}
