using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory : CarFactory
    {
        public override Vehicle Create()
        {
            var vehicle = new CarModelBuilder()
                .setModel("Mustang")
                .setColor("black")
                .Build();
            return new DefaultPropertiesVehicleDecorator(vehicle);
        }
    }
}
