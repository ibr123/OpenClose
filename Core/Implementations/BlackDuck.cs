using Core.Interfaces;
using Core.Models;
using System;

namespace Core.Implementations
{
    public class BlackDuck : DuckBaseClass, IDuckImplementation
    {
        public DuckTemplate CreateTemplate(IDuck duck)
        {
            try
            {
                DuckTemplate blackDuck = CreateBaseDuck(duck);
                blackDuck.FlyingMethod = "Vertical";
                blackDuck.Sound = "Soft Quack";
                return blackDuck;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
