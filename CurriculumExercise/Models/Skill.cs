namespace CurriculumExercise.Models
{
    public class Skill
    {


        public string Nome { get; set; }

        public int SkillValue { get; set; }



        public Skill(string nome , int value)
        {
            Nome = nome;
            SkillValue = value;
        }

    }
}
