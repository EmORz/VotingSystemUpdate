using System;
using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class MainClass
    {
        public List<string> list = new List<string>();

        public Dictionary<string, string> checkQ = new Dictionary<string, string>();

        public Dictionary<string, string> voted = new Dictionary<string, string>();

        public MainClass()
        {
            
        }
        //Methods
        public bool IsHadQ()
        {
            var a = 0;
            var b = 0;

            foreach (var q in checkQ)
            {
                if (q.Value.Equals("yes"))
                {
                    a++;
                }
                else if (q.Value.Equals("no"))
                {
                    b++;
                }
            }
            if (a > b)
            {
                return true;
            }
            return false;
        }

        public void PrintMembersOfCouncil()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i+" "+list[i]);
            }
        }

        public void AddData()
        {

            BSP bsp = new BSP();
            GERB gerb = new GERB();
            DPS dps = new DPS();
            KR kr = new KR();
            NOS nos = new NOS();
            RB rb = new RB();
            //
            bsp.Members();
            gerb.Members();
            dps.Members();
            kr.Members();
            nos.Members();
            rb.Members();
            //
            list.AddRange(bsp.mm);
            list.AddRange(gerb.m);
            list.AddRange(dps.mm);
            list.AddRange(kr.m);
            list.AddRange(nos.m);
            list.AddRange(rb.mm);
        }

    }
}