namespace CurriculumExercise.Models
{
    public class Work
    {
        public string Azienda { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public Work(string azienda, DateTime dataInizio, DateTime dataFine)
        {
            Azienda = azienda;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }
    }
}
