using System;
using System.Linq;
using System.Reflection;
using StartUp.Core.Engine.Contract;
using VotingLocalMunicipality.Entity;
using VotingLocalMunicipality.Entity.Vote;

namespace StartUp.Core.Engine
{
    public class Engine : IEngine
    {
        public BSP Bsp;
        public GERB Gerb;

        public Engine()
        {
            this.Bsp = new BSP();
            this.Gerb = new GERB();
        }
        public void Run()
        {
            AllM.Print();
            Bsp.Members();
            Label.PrintCommand();
            while (true)
            {
                var person = AllM.list;

                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == Label.stop)
                {
                    break;
                }

                var name = input[0] + " " + input[1] + " " + input[2];

                if (person.Contains(name))
                {
                    Vote.Add(name, input[3]);
                }

            }
            Vote.Count();
            Vote.Print();

        }
    }
}