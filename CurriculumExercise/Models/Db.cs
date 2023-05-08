using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace CurriculumExercise.Models
{
    public static class Db
    {
        public static List<Utente> Utenti { get; set; } = new List<Utente> { new Utente
            {
                Nome = "Davide",
                Cognome = "Luporini",
                UserName = "davidelupo",
                Password = "lupo",
                Skills = new List<Skill>()
            {
                new Skill ( "c#" , 80),
                new Skill ( "React" , 100),
                new Skill ( "Vue" , 60),
                new Skill ( "sql" , 33)
            },
                Lavori = new List<Lavoro>()
            {
                new Lavoro ( "Coop", new DateTime(2020, 1, 1), new DateTime(2022, 12, 31) ),
                new Lavoro ("Eurospin", new DateTime(2019, 1, 1), new DateTime(2020, 12, 31)),
                new Lavoro ("Florence consulting", new DateTime(2020, 1, 1), new DateTime(2022, 12, 31)),
                new Lavoro ("Avanade", new DateTime(2022, 12, 31), new DateTime(2022, 12, 31))
            }
            }
        };

        public static Utente GetUtente()
        {
            return Utenti.FirstOrDefault();
        }
        public static string VerifyUtente(Utente u)
        {
            var a = Utenti.FirstOrDefault(x => x.UserName == u.UserName && x.Password == u.Password);
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

        public static List<Skill> GetAllSkils()
        {
            return Utenti[0].Skills;
        }

        public static List<Lavoro> GetAllWorks()
        {
            return Utenti[0].Lavori;
        }


        public static void  addSkill(string nome , string valore)
        {
            Skill skillToAdd = new Skill(nome, int.Parse(valore));
           Utenti[0].Skills.Add(skillToAdd);
        }
        public static void AddWork(string nome , DateTime inizio , DateTime fine)
        {
            Lavoro workToAdd = new Lavoro(nome , inizio , fine);
            Utenti[0].Lavori.Add(workToAdd);
        }


    }
}