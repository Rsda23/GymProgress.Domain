using System.Text.Json.Serialization;

namespace GymProgress.Domain.Models
{
    public class SetData
    {
        [JsonPropertyName("setDataId")]
        public string SetDataId { get; set; } = string.Empty;
        [JsonPropertyName("repetition")]
        public int Repetition { get; set; }
        [JsonPropertyName("serie")]
        public int Serie { get; set; }
        [JsonPropertyName("charge")]
        public float Charge { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        public SetData()
        {

        }

        public SetData(int repetition, int serie, float charge, DateTime date)
        {
            Repetition = repetition;
            Serie = serie;
            Charge = charge;
            Date = date;
        }
    }
}
