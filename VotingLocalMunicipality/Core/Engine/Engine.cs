using StartUp.Core.Engine.Contract;
using System;
using System.Linq;
using VotingLocalMunicipality.Entity;
using VotingLocalMunicipality.Entity.Vote;

namespace StartUp.Core.Engine
{
    public class Engine : IEngine
    {
        public MainClass main;
        public Engine()
        {
            main = new MainClass();
        }
        public void Run()
        {
            main.AddData();
            var listOfAllMan = main.list;

            main.PrintMembersOfCouncil();

            Label.PrintCommand();
            while (true)
            {
                Console.WriteLine("Select command: ");
                var command = Console.ReadLine();

                if (command == Label.stop)
                {
                    Environment.Exit(0);
                }
                else if (command == Label.clear)
                {
                    Console.Clear();
                }
                else if (command == Label.info)
                {
                    main.PrintMembersOfCouncil();
                }
                else if (command == Label.qurum)
                {
                    Console.WriteLine("Enter data: ");
                    while (true)
                    {
                        string[] inputQ = Console.ReadLine().Split().ToArray();
                        if (inputQ[0] == Label.stop)
                        {
                            break;
                        }
                        var nameQ = inputQ[0] + " " + inputQ[1] + " " + inputQ[2];
                        main.checkQ.Add(nameQ, inputQ[3]);
                    }
                }
                if (main.IsHadQ() == false)
                {
                    Console.WriteLine("Dont have quorum!");
                    main.checkQ.Clear();
                    continue;
                }

                if (main.IsHadQ())
                {
                    Label.PrintCommand();
                    Console.WriteLine("Enter RV: ");
                    Console.WriteLine(main.checkQ.Where(x => x.Value == "yes").ToArray().Count());
                    Console.WriteLine(main.checkQ.Where(x => x.Value == "no").ToArray().Count());
                    //
                    while (true)
                    {
                        string[] input = Console.ReadLine().Split().ToArray();
                        if (input[0] == Label.stop)
                        {
                            break;
                        }
                        var name = input[0] + " " + input[1] + " " + input[2];
                        if (main.checkQ.ContainsKey(name))
                        {
                            main.voted.Add(name, input[3]);
                        }
                    }
                    Console.WriteLine(main.voted.Where(x => x.Value == "yes").ToArray().Count());
                    Console.WriteLine(main.voted.Where(x => x.Value == "no").ToArray().Count());
                    Console.WriteLine(main.voted.Where(x => x.Value == "pass").ToArray().Count());
                    foreach (var prt in main.voted)
                    {
                        Console.WriteLine(prt.Key + " => "+prt.Value);
                    }
                }
                main.checkQ.Clear();
                main.voted.Clear();
            }
        }
    }
}