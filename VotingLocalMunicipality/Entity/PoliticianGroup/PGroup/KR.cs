using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class KR
    {
        public List<string> m = new List<string>();

        public string first = "Божинел Василев Христов";
        public string second = "Владимир Димитров Димитров";
        public string third = "Калоян Руменов Монев";



        public void Members()
        {
            m.Add(first);
            m.Add(second);
            m.Add(third);
        }
    }
}