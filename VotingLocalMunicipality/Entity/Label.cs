using System;
using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public static class Label
    {
        public static string stop = "stop";
        public static string qurum = "Qurum";
        public static string commands = "Commands";
        public static string clear = "Clear";
        public static string info = "Info";

        public static List<string> command = new List<string>()
        {
            stop,
            qurum,
            clear
        };

        public static void PrintCommand()
        {
            Console.WriteLine(commands);
            foreach (var commands in command)
            {
                Console.Write(commands+";");
            }

            Console.WriteLine();
        }
    }
}