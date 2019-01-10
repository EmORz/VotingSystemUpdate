using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class BSP
    {
        public List<string> mm = new List<string>();
        public string first = "Елка Александрова Неделчева";
        public string second = "Стоян Димитров Ненчев";
        public string third = "Диана Добромирова Мирчева-Рахнева";
        public string fourth = "Илия Христов Илиев";
        public string five = "Таня Петрова Тодорова";

        public void Members()
        {
            AllM.list.Add(first);
            AllM.list.Add(second);
            AllM.list.Add(third);
            AllM.list.Add(fourth);
            AllM.list.Add(five);

            mm.Add(first);
            mm.Add(second);
            mm.Add(third);
            mm.Add(fourth);
            mm.Add(five);
        }


    }
}