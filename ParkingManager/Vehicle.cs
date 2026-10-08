using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class Vehicle
    {
        private string _plate { get; set; }
        private int _year { get; set; }
        private bool _isElectric { get; set; }
        private static int _count = 0;
        private int _balance { get; set; }
        private int _hoursParked { get; set; }
        public string Plate { get { return _plate; } set { value = _plate; } }
        public int Year { get { return _year; } set { value = _year > 1990 && _year < 2026 ? _year : 0; } }
        public bool IsElectric { get { return _isElectric; } set { value = _isElectric; } }
        public static int Count { get { return _count; } }
        public int Balance { get { return _balance; } }
        public int HoursParked { get { return _hoursParked; } }
        public Vehicle(string plate, int year, bool isElectric)
        {
            _plate = plate;
            _year = year;
            _isElectric = isElectric;
            _count++;
        }
        public bool TopUp(int amount)
        {
            _balance += amount == 1000 || amount == 2000 || amount == 5000 ? amount : 0;
            return amount == 1000 || amount == 2000 || amount == 5000;
        }
        public bool Park(int hours)
        {
            if (_isElectric)
            {
                if (_balance - hours * 200 >= 0 && _hoursParked >= 1)
                {
                    _hoursParked += hours;
                    _balance -= 200 * hours;
                    return true;
                }
                return false;
            }
            if (_balance - hours * 400 >= 0 && _hoursParked >= 1)
            {
                _hoursParked += hours;
                _balance -= 400 * hours;
                return true;
            }
            return false;
        }
        public string GetDescription()
        {
            string car = IsElectric ? "electric" : "fossil fuel";
            string year = Year == 0 ? "unknown date" : $"{Year}";
            return $"{Plate} ({year}, {car}): {Balance} Ft balance, {HoursParked} hour(s) parked";
        }
    }
}
