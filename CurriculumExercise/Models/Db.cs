using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace CurriculumExercise.Models
{
    public static class Db
    {
        public static User? UserLogged { get; set; } = null;
        public static List<User> Utenti { get; set; } = new List<User> { 
            new User
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
                Lavori = new List<Work>()
            {
                new Work ( "Coop", new DateTime(2020, 1, 1), new DateTime(2022, 12, 31) ),
                new Work ("Eurospin", new DateTime(2019, 1, 1), new DateTime(2020, 12, 31)),
                new Work ("Florence consulting", new DateTime(2020, 1, 1), new DateTime(2022, 12, 31)),
                new Work ("Avanade", new DateTime(2022, 12, 31), new DateTime(2022, 12, 31))
            }
            },
             new User
            {
                Nome = "Valerio",
                Cognome = "Valdes",
                UserName = "Valeriovaldes",
                Password = "valdes",
                Skills = new List<Skill>()
            {
                new Skill ( "c#" , 100),
                new Skill ( "React" , 10),
                new Skill ( "Vue" , 20),
                new Skill ( "sql" , 15)
            },
                Lavori = new List<Work>()
            {
                new Work ("Avanade", new DateTime(2022, 12, 31), new DateTime(2022, 12, 31))
            }
            }
        };

        public static User GetUtente()
        {
            var a = Utenti.FirstOrDefault(x => x.UserName == UserLogged.UserName && x.Password == UserLogged.Password);
            
            return a;
        }
        public static string VerifyUtente(User u)
        {
            var a = Utenti.FirstOrDefault(x => x.UserName == u.UserName && x.Password == u.Password);

            if (a != null)
            {
                UserLogged = a;
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
            return Utenti[Db.FindUserIndex()].Skills;
        }

        public static List<Work> GetAllWorks()
        {
            return Utenti[Db.FindUserIndex()].Lavori;
        }


        public static void  addSkill(string nome , string valore)
        {
            Skill skillToAdd = new Skill(nome, int.Parse(valore));
            Utenti[Db.FindUserIndex()].Skills.Add(skillToAdd);
        }
        public static void AddWork(string nome , DateTime inizio , DateTime fine)
        {
            Work workToAdd = new Work(nome , inizio , fine);
            
            Utenti[Db.FindUserIndex()].Lavori.Add(workToAdd);
        }


        public static int FindUserIndex()
        {
            int index = Utenti.IndexOf(Db.GetUtente());
            return index;
        }

        public static void LogginOut()
        {
            UserLogged = null;
        }

    }
}