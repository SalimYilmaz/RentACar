using Core.Entities;

namespace Entities.Concrete
{
    public class Transmission : Entity<int>
    {
        public string Name { get; set; }

        
        // Constructor
        public Transmission() { }

        public Transmission(string name)
        {
            Name = name;
        }
    }
}