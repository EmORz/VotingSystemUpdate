using System;
using System.Collections.Generic;

namespace StartUp.Entity
{
    public static class Bullettin
    {
        public static string Yes = "Yes";
        public static string No = "No";
        public static string Pass = "Pass";

        public static List<string> all = new List<string> { Yes, No, Pass};

        public static void Print()
        {
            Console.WriteLine("Select");
            Console.WriteLine(string.Join(" ", all));
        }

        public static string EnterName = "Name: ";
        public static string EnterVote = "Enter vote: ";
        public static string Invalid = "Invalid - You cant vote second time";

        public static string Result = "Result";
        public static string AllVote = "All Vote";

        public static string Stop = "Stop";

    }
}