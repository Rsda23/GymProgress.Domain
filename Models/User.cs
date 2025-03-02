using System.Text.Json.Serialization;

namespace GymProgress.Domain.Models
{
    public class User
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
        [JsonPropertyName("pseudo")]
        public string Pseudo { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("hashedPassword")]
        public string HashedPassword { get; set; }

        public User()
        {
                
        }

        public User(string pseudo, string email, string hashedPassword)
        {
            Pseudo = pseudo;
            Email = email;
            HashedPassword = hashedPassword;
        }
    }
}
