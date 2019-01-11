using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class GERB
    {
        public List<string> m = new List<string>();

        public string first = "Радиана Ангелова Димитрова";
        public string second = "Валентина Маркова Френкева-Белчева";
        public string third = "Галин Пенчев Парашкевов";
        public string fourth = "Гюлвер Исмаил Хасан";
        public string fifht = "Мариан Пламенов Иванов";
        public string sixth = "Марина Петрова Христова";
        public string seventh = "Надежда Радославова Димитрова";
        public string eight = "Наско Стоилов Анастасов";
        public string nine = "Светослав Теофилов Банков";
        public string ten = "Стефан Димов Стефанов";


        public void Members()
        {
               m.Add(first);
               m.Add(second);
               m.Add(third);
               m.Add(fourth);
               m.Add(fifht);
               m.Add(sixth);
               m.Add(seventh);
               m.Add(eight);
               m.Add(nine);
               m.Add(ten);
        }

    }
}