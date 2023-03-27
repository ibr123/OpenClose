using Core.Interfaces;

namespace Core.Models
{
    public class DuckTemplate //: IDuckTemplate
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public string Sound { get; set; }
        public string FlyingMethod { get; set; }
    }
}
