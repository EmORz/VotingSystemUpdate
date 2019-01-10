using System;
using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity.Vote
{
    public static class Vote
    {
        public static Dictionary<string, string> yes = new Dictionary<string, string>();

        public static void Add(string name, string command)
        {
            if (command == "yes" || command == "no" || command == "pass")
            {
                yes.Add(name, command);
            }
        }

        public static void Print()
        {
            BSP bsp = new BSP();
            bsp.Members();
            GERB gerb = new GERB();
            gerb.Members();

            foreach (var ye in yes)
            {
                if (bsp.mm.Contains(ye.Key))
                {
                    Console.WriteLine(ye.Key + " => " + ye.Value+" "+bsp.GetType().Name);

                }
                if (gerb.m.Contains(ye.Key))
                {
                    Console.WriteLine(ye.Key + " => " + ye.Value + " " + gerb.GetType().Name);

                }

            }
        }

        public static void Count()
        {
            var a = 0;
            var b = 0;
            var c = 0;

            foreach (var ye in yes)
            {
                if (ye.Value.Equals("yes"))
                {
                    a++;
                }
                else if (ye.Value.Equals("no"))
                {
                    b++;
                }
                else if (ye.Value.Equals("pass"))
                {
                    c++;
                }

            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}