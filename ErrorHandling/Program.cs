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
        }
    }

    class Game
    {
        Monsters_Cohort monsterCohort = new Monsters_Cohort(1, "02/09/2019");
        public void Initialize()
        {
            for (int i = 1; i <= 5; i++)
            {
                Monster_Student ms = new Monster_Student(i, String.Format("Ability{0}",i));
                monsterCohort.AddStudent(ms);
            }

            DoSomething();
        }

        public void DoSomething()
        {
            monsterCohort.ListStudent();
        }
    }

    class Monster_Student
    {
        #region Fields
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
        #endregion

        public Monster_Student(int id)
        {
            this.id = id;
        }
        
        public Monster_Student(int id, String specAbility)
        {
            this.id = id;
            this.specialAbility = specAbility;
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
        #region Fields
        int subject;
        public int Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        string startDate;
        string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        List<Monster_Student> students = new List<Monster_Student>();
        #endregion

        public Monsters_Cohort(int id, string start)
        {
            this.subject = id;
            this.startDate = start;
        }
        public void AddStudent(Monster_Student ms)
        {
            students.Add(ms);
        }
        public void ListStudent()
        {
            foreach (Monster_Student ms in students)
            {
                Console.WriteLine(String.Format("Id: {0}, {1}", ms.Id, ms.SpecialAbility));
            }
        }
    }
}
