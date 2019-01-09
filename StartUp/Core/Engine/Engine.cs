using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            Bullettin.yes.AddRange(ListPerson.Where(x => x.Vote == Bullettin.Yes));
            Bullettin.no.AddRange(ListPerson.Where(x => x.Vote == Bullettin.No));
            Bullettin.pass.AddRange(ListPerson.Where(x => x.Vote == Bullettin.Pass));
            //

            Console.WriteLine(Bullettin.Result);
            Console.WriteLine(Bullettin.AllVote+ListPerson.Count);
            Console.WriteLine(Bullettin.dots);
            //
            var percY = Bullettin.yes.Count*1.0 / ListPerson.Count*1.0;
            Console.WriteLine($"{percY * 100:f2} %");

            Bullettin.PrintY();

            Bullettin.PrintN();
            var percN = Bullettin.no.Count*1.0 / ListPerson.Count * 1.0;
            Console.WriteLine($"{percN * 100:f2} %");


            Bullettin.PrintP();
            var perPass = Bullettin.pass.Count*1.0 / ListPerson.Count * 1.0;
            Console.WriteLine($"{perPass*100:f2} %");

        }
    }
}