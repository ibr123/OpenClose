using Core.Implementations;
using Core.Interfaces;

namespace Core.Models
{
    public class GreenDuckModel:IDuck
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public IDuckImplementation DuckImplementation { get; set; } = new GreenDuck();
    }
}
