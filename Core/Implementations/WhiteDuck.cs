using Core.Interfaces;
using Core.Models;
using System;

namespace Core.Implementations
{
    public class WhiteDuck : DuckBaseClass, IDuckImplementation
    {
        public DuckTemplate CreateTemplate(IDuck duck)
        {
            try
            {
                DuckTemplate whiteDuck = CreateBaseDuck(duck);
                whiteDuck.FlyingMethod = "swinging";
                whiteDuck.Sound = "Sharp Quack";
                return whiteDuck;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
