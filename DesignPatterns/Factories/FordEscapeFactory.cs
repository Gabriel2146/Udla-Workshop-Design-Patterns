using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .setColor("Red")
                .setBrand("Ford")
                .Build();
        }
    }
}
