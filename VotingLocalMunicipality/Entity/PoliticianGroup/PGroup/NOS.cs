using System.Collections.Generic;

namespace VotingLocalMunicipality.Entity
{
    public class NOS
    {
        public List<string> m = new List<string>();

        public string first = "Фатме Селим Али";
        public string second = "Милена Дачева Орешкова";
        public string third = "Рейхан Ридван Вели";
        public string forth = "Янка Трифонова Георгиева";



        public void Members()
        {
            m.Add(first);
            m.Add(second);
            m.Add(third);
            m.Add(forth);
        }
    }
}