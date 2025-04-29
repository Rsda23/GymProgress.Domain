using System.Text.Json.Serialization;

namespace GymProgress.Domain.Models
{
    public class SetData
    {
        [JsonPropertyName("setDataId")]
        public string SetDataId { get; set; } = string.Empty;
        [JsonPropertyName("exerciceId")]
        public string ExerciceId { get; set; } = string.Empty;
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

        public SetData()
        {

        }

        public SetData(string exerciceId, int repetition, int serie, float charge, DateTime date)
        {
            ExerciceId = exerciceId;
            Repetition = repetition;
            Serie = serie;
            Charge = charge;
            Date = date;
        }

        public SetData(string setDataId, string exerciceId, int repetition, int serie, float charge, DateTime date)
        {
            SetDataId = setDataId;
            ExerciceId = exerciceId;
            Repetition = repetition;
            Serie = serie;
            Charge = charge;
            Date = date;
        }

        public SetData(string exerciceId, int repetition, int serie, float charge, DateTime date, string userId)
        {
            ExerciceId = exerciceId;
            Repetition = repetition;
            Serie = serie;
            Charge = charge;
            Date = date;
            UserId = userId;
        }

        public SetData(string setDataId, string exerciceId, int repetition, int serie, float charge, DateTime date, string userId)
        {
            SetDataId = setDataId;
            ExerciceId = exerciceId;
            Repetition = repetition;
            Serie = serie;
            Charge = charge;
            Date = date;
            UserId = userId;
        }
    }
}
