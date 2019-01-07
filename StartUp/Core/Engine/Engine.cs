using System;
using System.Collections.Generic;
using StartUp.Core.Engine.Contract;
using StartUp.Entity;

namespace StartUp.Core.Engine
{
    public class Engine : IEngine
    {
        public IPerson Person;
        public List<IPerson> ListPerson = new List<IPerson>();

        public Engine()
        {
            this.Person = new Person();
        }
        public void Run()
        {
            while (true)
            {
                Bullettin.Print();

                Console.Write(Bullettin.EnterName);
                string name = Console.ReadLine();
                var hashName = name.GetHashCode().ToString();

                if (ListPerson.Exists(x => x.Name == hashName))
                {
                    Console.WriteLine(Bullettin.Invalid);
                    continue;
                }
                if (name == Bullettin.Stop)
                {
                    break;
                }

                Console.Write(Bullettin.EnterVote);
                string vote = Console.ReadLine();
                if (Bullettin.all.Contains(vote))
                {
                    Person = new Person(hashName, vote);
                    ListPerson.Add(Person);
                }
            }
            Console.WriteLine(Bullettin.Result);
            Console.WriteLine(Bullettin.AllVote+ListPerson.Count);
            foreach (var person in ListPerson)
            {
                Console.WriteLine(person.Name+" => "+person.Vote);
            }
        }
    }
}