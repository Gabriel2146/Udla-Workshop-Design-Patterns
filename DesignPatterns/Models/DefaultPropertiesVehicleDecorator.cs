using System;
using System.Collections.Generic;

namespace DesignPatterns.Models
{
    public class DefaultPropertiesVehicleDecorator
    {
        private readonly Vehicle _vehicle;

        // Propiedades por defecto adicionales
        public int Year { get; private set; }
        public Dictionary<string, object> DefaultProperties { get; private set; }

        public DefaultPropertiesVehicleDecorator(Vehicle vehicle)
        {
            _vehicle = vehicle;
            Year = DateTime.Now.Year;

            // Inicializar 20 propiedades por defecto con valores de ejemplo
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

        // Métodos para delegar al vehículo original
        public void StartEngine()
        {
            _vehicle.StartEngine();
        }

        public void StopEngine()
        {
            _vehicle.StopEngine();
        }

        public void AddGas()
        {
            _vehicle.AddGas();
        }

        // Propiedades para acceder a las propiedades del vehículo original
        public string Color => _vehicle.Color;
        public string Brand => _vehicle.Brand;
        public string Model => _vehicle.Model;
        public int VehicleYear => Year;

        // Otros métodos y propiedades pueden ser delegados o extendidos según necesidad
    }
}
