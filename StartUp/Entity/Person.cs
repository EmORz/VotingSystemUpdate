namespace StartUp.Entity
{
    public class Person : IPerson
    {
        public Person()
        {
            
        }
        public Person(string name, string vote)
        {
            this.Name = name;
            this.Vote = vote;
        }

        public string Name { get; set; }

        public string Vote { get; set; }
    }
}