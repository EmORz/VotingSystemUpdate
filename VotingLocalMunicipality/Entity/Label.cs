using System;
using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public static class Label
    {
        public static string stop = "stop";

        public static List<string> command = new List<string>()
        {
            stop
        };

        public static void PrintCommand()
        {
            foreach (var commands in command)
            {
                Console.WriteLine(commands);
            }
        }
    }
}