using System;
using System.Collections.Generic;

namespace StartUp.Entity
{
    public static class Bullettin
    {
        public static string Yes = "Yes";
        public static string No = "No";
        public static string Pass = "Pass";

        public static List<string> all = new List<string> {Yes, No, Pass};

        public static List<IPerson> yes = new List<IPerson>();
        public static List<IPerson> no = new List<IPerson>();
        public static List<IPerson> pass = new List<IPerson>();
        public static List<IPerson> AllVotingPeople = new List<IPerson>();

        public static int AllVField()
        {
            AllVotingPeople.AddRange(yes);
            AllVotingPeople.AddRange(no);
            AllVotingPeople.AddRange(pass);
            return AllVotingPeople.Count;

        }

        private static double temp => AllVField();

        public static void PrintY()
        {
            Console.WriteLine("Voting Yes => "+yes.Count);

            foreach (var person in yes)
            {
                Console.WriteLine(person.Name + " => "+person.Vote);
            }
        }
        public static void PrintN()
        {
            Console.WriteLine("Voting No => "+no.Count );
            foreach (var person in no)
            {
                Console.WriteLine(person.Name + " => " + person.Vote);
            }
        }
        public static void PrintP()
        {
            Console.WriteLine("Voting Pass => " +pass.Count);
            foreach (var person in pass)
            {
                Console.WriteLine(person.Name + " => " + person.Vote);
            }
        }



        public static void Print()
        {
            Console.WriteLine("Select");
            Console.WriteLine(string.Join(" ", all));
        }

        public static string EnterName = "Name: ";
        public static string EnterVote = "Enter vote: ";
        public static string Invalid = "Invalid - You cant vote second time";

        public static string dots = new string('*', 10);
        public static string Result = "RESULT"+"\n"+dots;
        public static string AllVote = "All Vote => ";

        public static string Stop = "Stop";

    }
}