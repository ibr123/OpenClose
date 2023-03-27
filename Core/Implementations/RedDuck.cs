using Core.Interfaces;
using Core.Models;

namespace Core.Implementations
{
    public class RedDuck : DuckBaseClass, IDuckImplementation
    {
        public DuckTemplate CreateTemplate(IDuck duck)
        {
            try
            {
                DuckTemplate redDuck = CreateBaseDuck(duck);
                redDuck.FlyingMethod = "ZigZag";
                redDuck.Sound = "Quack";
                return redDuck;
            }
            catch
            {
                throw;
            }
        }
    }
}
