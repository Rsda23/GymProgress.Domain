
namespace GymProgress.Domain.Models
{
    public class Seance
    {
        public string SeanceId { get; set; }
        public string Name { get; set; }
        public List<Exercice> Exercices { get; set; }

        public Seance(string name, List<Exercice> exercices)
        {
            Name = name;
            Exercices = exercices;
        }
        public Seance(List<Exercice> exercices)
        {
            Exercices = exercices;
        }
        public Seance(string name)
        {
            Name = name;
        }
    }
}
