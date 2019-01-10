using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace VotingLocalMunicipality.Entity
{
    public static class AllM
    {
        public static List<string> list = new List<string>();


        public static void Print()
        {

            BSP bsp = new BSP();
            bsp.Members();
            
            GERB gerb = new GERB();
            gerb.Members();

            var countB = 1;
            var countG = 1;
            for (int i = 0; i < list.Count; i++)
            {
                var b = bsp.mm.Contains(list[i]);
                var g = gerb.m.Contains(list[i]);

                if (b)
                {
                    Console.WriteLine($"{countB++}" + " => " + list[i]+" polit group => "+bsp.GetType().Name);
                }
                if (g)
                {
                    Console.WriteLine($"{countG++}" + " => " + list[i] + " polit group => " + gerb.GetType().Name);
                }

            }
        }

    }
}