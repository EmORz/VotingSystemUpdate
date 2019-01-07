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
                string name = Console.ReadLine();
                //ideqta e 4e imenata na glasuvalite se pazqt v lista v hashiran type - taina na vota :) 
                var hashName = name.GetHashCode().ToString();
                //validiram dali ne se sydyrja ve4e 
                if (ListPerson.Exists(x => x.Name == hashName))
                {
                    Console.WriteLine("Invalid");
                    continue;
                }
                //za prekysvane na izpylnenieto
                if (name == "s")
                {
                    break;
                }
                //samiqt vot - validiram dali e ot vaidnite
                string vote = Console.ReadLine();
                if (Bullettin.all.Contains(vote))
                {
                    Person = new Person(hashName, vote);
                    ListPerson.Add(Person);
                }
            }

            Console.WriteLine("Result");
            Console.WriteLine("All Vote"+ListPerson.Count);
            foreach (var person in ListPerson)
            {
                Console.WriteLine(person.Name+" => "+person.Vote);
            }
        }
    }
}