namespace Case_2.Models
{
 
    public class Building
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Building()
        {
            
        }

        // contructor
        public Building(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Building {Id}: {Name}";
        }
    }
}
