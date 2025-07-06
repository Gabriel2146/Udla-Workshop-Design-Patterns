using System;
using System.Collections.Generic;

namespace DesignPatterns.Models
{
    public class ExtendedCar : Car
    {
        public int Year { get; private set; }
        public Dictionary<string, object> DefaultProperties { get; private set; }

        public ExtendedCar(string color, string brand, string model, int year) : base(color, brand, model, year)
        {
            Year = year;

            DefaultProperties = new Dictionary<string, object>
            {
                { "Property1", "DefaultValue1" },
                { "Property2", "DefaultValue2" },
                { "Property3", 0 },
                { "Property4", false },
                { "Property5", 100 },
                { "Property6", "DefaultValue6" },
                { "Property7", "DefaultValue7" },
                { "Property8", 1.5 },
                { "Property9", DateTime.Now },
                { "Property10", "DefaultValue10" },
                { "Property11", true },
                { "Property12", 42 },
                { "Property13", "DefaultValue13" },
                { "Property14", 3.14 },
                { "Property15", "DefaultValue15" },
                { "Property16", 999 },
                { "Property17", "DefaultValue17" },
                { "Property18", false },
                { "Property19", "DefaultValue19" },
                { "Property20", 12345 }
            };
        }
    }
}
