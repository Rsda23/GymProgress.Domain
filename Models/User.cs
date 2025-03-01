namespace GymProgress.Domain.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
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
