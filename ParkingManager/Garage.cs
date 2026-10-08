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
        public Vehicle FindByPlate(string plate)
        {
            Vehicle veh = null;
            foreach (Vehicle v in _vehicles)
            {
                if (v.Plate == plate)
                {
                    veh = v;
                }
            }
            return veh;
        }
        public bool RemoveVehicle(string plate)
        {
            int original = _vehicles.Count;
            _vehicles.Remove(FindByPlate(plate));
            if (_vehicles.Count < original)
            {
                return true;
            }
            return false;
        }
        public List<Vehicle> LowBalance()
        {
            return _vehicles.Where(x => x.Balance < 1000).ToList();
        }
        public int TotalHours()
        {
            int total = 0;
            foreach (Vehicle v in _vehicles)
            {
                total += v.HoursParked;
            }
            return total;
        }
        public Vehicle LongestParked()
        {
            if (_vehicles.Count == 0)
            {
                return null;
            }
            return _vehicles.OrderByDescending(x => x.HoursParked).First();
        }
    }
}
