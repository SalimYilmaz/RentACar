using Core.Entities;

namespace Entities.Concrete
{
    public class Fuel : Entity<int>
    {
        public string Name { get; set; }

      
        // Constructor
        public Fuel() { }

        public Fuel(string name)
        {
            Name = name;
        }
    }
}