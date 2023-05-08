using System.Linq.Expressions;

namespace CurriculumExercise.Models
{
    public static class Db
    {
        public static List<Utente> Utenti { get; set; } = new List<Utente> { new Utente
            {
                Nome = "John",
                Cognome = "Doe",
                UserName = "johndoe",
                Password = "password",
                Skills = new List<Skill>()
            {
                new Skill ( "c#" , 8)
            },
                Lavori = new List<Lavoro>()
            {
                new Lavoro { Azienda = "Acme Inc.", DataInizio = new DateTime(2020, 1, 1), DataFine = new DateTime(2022, 12, 31) }
            }
            }
        };

        public static Utente GetUtente()
        {
            return Utenti.FirstOrDefault();
        }        
        public static string VerifyUtente(Utente u)
        {
            var a = Utenti.FirstOrDefault( x => x.UserName == u.UserName && x.Password == u.Password);
            if (a != null)
            {
                return Randomize().ToString();
            }
            else return null;
        }

        private static int Randomize()
        {
            var rnd = new Random();
            return rnd.Next(1, 10000);
        }


    }
}
