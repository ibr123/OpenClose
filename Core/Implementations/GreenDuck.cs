using Core.Interfaces;
using Core.Models;
using System;

namespace Core.Implementations
{
    public class GreenDuck : DuckBaseClass, IDuckImplementation
    {
        /// <summary>
        /// has no flying method only sound 
        /// </summary>
        /// <param name="duck"></param>
        /// <returns></returns>
        public DuckTemplate CreateTemplate(IDuck duck)
        {
            try
            {
                DuckTemplate yellowDuck = CreateBaseDuck(duck);
                yellowDuck.Sound = "Melodic";
                return yellowDuck;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
