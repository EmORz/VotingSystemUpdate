using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class RB
    {
        public List<string> mm = new List<string>();
        public string first = "Митко Иванов Ханчев";
        public string second = "Веселин Валентинов Спасов";
        public string third = "Джипо Николов Джипов";
        public string fourth = "Иво Борисов Димитров";
        public string five = "Мануел Василев Чутурков";

        public void Members()
        {
            mm.Add(first);
            mm.Add(second);
            mm.Add(third);
            mm.Add(fourth);
            mm.Add(five);
        }
    }
}