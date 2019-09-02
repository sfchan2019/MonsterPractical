using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Initialize();
            game.Do();
        }
    }

    class Game
    {
        public void Initialize()
        {
            Monsters_Cohort monsterCohort = new Monsters_Cohort();
            for (int i = 0; i < 5; i++)
            {
                Monster_Student ms = new Monster_Student(i);
                monsterCohort.AddStudent(ms);
            }
        }

        public void Do()
        {

        }
    }

    class Monster_Student
    {
        int id;
        public int Id
        {
            get { return id; }
        }
        string eyes;
        public string Eyes
        {
            get { return eyes; }
            set { eyes = value; }
        }
        string hair;
        public string Hair
        {
            get { return hair; }
            set { hair = value; }
        }
        float scaryLevel;
        public float ScaryLevel
        {
            get { return scaryLevel; }
            set { scaryLevel = value; }
        }
        string specialAbility;
        public string SpecialAbility
        {
            get { return specialAbility; }
            set { specialAbility = value; }
        }

        public Monster_Student(int id)
        {
            this.id = id;
        }
        public Monster_Student(int id, string eyes, string hair, float scaryLevel, string specAbility)
        {
            this.id = id;
            this.eyes = eyes;
            this.hair = hair;
            this.scaryLevel = scaryLevel;
            specialAbility = specAbility;
        }
        public void Jump()
        {
            Console.WriteLine("Jump");
        }

        public void Scream()
        {
            Console.WriteLine("Scream");
        }
    }

    class Monsters_Cohort
    {
        int subject;
        string startDate;
        List<Monster_Student> students = new List<Monster_Student>();

        public void AddStudent(Monster_Student ms)
        {
            students.Add(ms);
        }
        public void ListStudent()
        {
            foreach (Monster_Student ms in students)
            {
                Console.WriteLine(ms.Id.ToString() + ms.SpecialAbility);
            }
        }
        public void ImportStudent()
        {

        }
    }
}
