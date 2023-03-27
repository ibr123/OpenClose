using Core.Interfaces;
using Core.Models;

namespace Core.Implementations
{
    public class DuckBaseClass
    {
        public DuckTemplate CreateBaseDuck(IDuck duck)
        {
            return new DuckTemplate()
            {
                Color = duck.Color,
                Name = duck.Name,
                Size = duck.Size,
            };
        }
    }
}
