namespace Case_2.Models
{
 
    public class Building
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // contructor
        public Building(int id, string name)
        {
            Id = id;
            Name = name;
            Address = Address;
        }

        public override string ToString()
        {
            return $"Building {Id}: {Name}";
        }
    }
}
