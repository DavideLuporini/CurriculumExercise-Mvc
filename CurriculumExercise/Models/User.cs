namespace CurriculumExercise.Models
{
    public class User
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        public List<Work> Lavori { get; set; } = new List<Work>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}
