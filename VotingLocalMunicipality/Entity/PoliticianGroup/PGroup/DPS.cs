using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class DPS
    {
        public List<string> mm = new List<string>();
        public string first = "Левент Али Апти";
        public string second = "Ахтер Исметов Чилев";
        public string third = "Емине Бейти Хасан";
        public string fourth = "Фатме Зелкиф Емин";
        public string five = "Хами Ибрахимов Хамиев";
        public string six = "Хасан Халилов Хасанов";

        public void Members()
        {
            mm.Add(first);
            mm.Add(second);
            mm.Add(third);
            mm.Add(fourth);
            mm.Add(five);
            mm.Add(six);
        }
    }
}