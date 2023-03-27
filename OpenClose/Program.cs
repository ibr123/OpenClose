using Core.Implementations;
using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDuck> ducks = new List<IDuck>()
            {
                new BlackDuckModel{ Color="Black", Name="Duck 1", Size=5},
                new WhiteDuckModel{ Color="White", Name="Duck 2", Size=6},
                new RedDuckModel{ Color="Red", Name="Duck 3", Size=7},
                new YellowDuckModel{ Color="Yellow", Name="Duck 4", Size=8},
                new GreenDuckModel{ Color="Green", Name="Duck 5", Size=9},
            };

            List<DuckTemplate> duckTemplate = new List<DuckTemplate>();

            ducks.ForEach(duck =>
            {
                duckTemplate.Add(duck.DuckImplementation.CreateTemplate(duck));
            });

            duckTemplate.ForEach(template =>
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{template.Name} is of color {template.Color} and its size is {template.Size}, is sound is {template.Sound}");
                
                if(!string.IsNullOrEmpty(template.FlyingMethod))
                {
                    stringBuilder.Append($" and its flying method is {template.FlyingMethod}");
                }
                Console.WriteLine(stringBuilder.ToString());
            });
        }
    }
}
