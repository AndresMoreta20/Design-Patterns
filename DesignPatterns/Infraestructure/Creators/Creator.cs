using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Creator
{
    public class Creator
    {

        public static Car CreateVehicle(string model, string brand, string color, int year)
        {
            return new Car(model, brand, color, year);
        }
    }
}
