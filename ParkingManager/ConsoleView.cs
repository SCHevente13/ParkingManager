using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class ConsoleView
    {
        public void ShowVehicle(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetDescription());
        }
        public void ShowVehicles(List<Vehicle> vehicles)
        {
            Console.WriteLine("Vehicles in the list:");
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($" - {v.GetDescription()}");
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
