using Core.Interfaces;
using Core.Models;
using System;

namespace Core.Implementations
{
    /// <summary>
    /// has no flying method only sound 
    /// </summary>
    public class YellowDuck : DuckBaseClass, IDuckImplementation
    {
        public DuckTemplate CreateTemplate(IDuck duck)
        {
            try
            {
                DuckTemplate yellowDuck = CreateBaseDuck(duck);
                yellowDuck.Sound = "Double Quack";
                return yellowDuck;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
