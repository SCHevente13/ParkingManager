using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class Garage
    {
        private string _name { get; set; }
        private int _capacity { get; set; }
        private List<Vehicle> _vehicles { get; set; }
        public string Name { get { return _name; } set { value = _name; } }
        public int Capacity { get { return _capacity; } }
        public List<Vehicle> Vehicles { get { return _vehicles; } }
        public Garage(string name, int capacity)
        {
            _name = name;
            _capacity = capacity;
            _vehicles = new List<Vehicle>();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            if (_vehicles.Count >= _capacity)
            {
                return false;
            }
            _vehicles.Add(vehicle);
            return true;
        }

    }
}
