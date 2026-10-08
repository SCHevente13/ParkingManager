namespace ParkingManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("AHJ-635", 1991, false));
            vehicles.Add(new Vehicle("PFG-916", 2015, true));
            vehicles.Add(new Vehicle("AAA-001", 1980, false));
            vehicles.Add(new Vehicle("UJC-258", 2020, true));
            if (vehicles[0].TopUp(5000))
            {
                ConsoleView.ShowMessage("Balance topped up succesfully");
            }
            else
            {
                ConsoleView.ShowMessage("Balance wasn't topped up correctly");
            }
            if (vehicles[1].TopUp(1000))
            {
                ConsoleView.ShowMessage("Balance topped up succesfully");
            }
            else
            {
                ConsoleView.ShowMessage("Balance wasn't topped up correctly");
            }
            if (vehicles[2].TopUp(3000))
            {
                ConsoleView.ShowMessage("Balance topped up succesfully");
            }
            else
            {
                ConsoleView.ShowMessage("Balance wasn't topped up correctly");
            }
            if (vehicles[3].TopUp(2000))
            {
                ConsoleView.ShowMessage("Balance topped up succesfully");
            }
            else
            {
                ConsoleView.ShowMessage("Balance wasn't topped up correctly");
            }
            if (vehicles[0].Park(5))
            {
                ConsoleView.ShowMessage("Parking succesful");
            }
            else
            {
                ConsoleView.ShowMessage("Parking unsuccesful");
            }
            if (vehicles[1].Park(2))
            {
                ConsoleView.ShowMessage("Parking succesful");
            }
            else
            {
                ConsoleView.ShowMessage("Parking unsuccesful");
            }
            if (vehicles[2].Park(6))
            {
                ConsoleView.ShowMessage("Parking succesful");
            }
            else
            {
                ConsoleView.ShowMessage("Parking unsuccesful");
            }
            if (vehicles[3].Park(3))
            {
                ConsoleView.ShowMessage("Parking succesful");
            }
            else
            {
                ConsoleView.ShowMessage("Parking unsuccesful");
            }
            ConsoleView.ShowVehicles(vehicles);
            ConsoleView.ShowMessage($"Count of vehicles made: {vehicles.Count}");
            Garage garage = new Garage("The Big One", 3);
            foreach (Vehicle v in vehicles)
            {
                if (garage.AddVehicle(v))
                {
                    ConsoleView.ShowMessage("Successfully added vehicle to garage");
                }
                else
                {
                    ConsoleView.ShowMessage("Garage is full");
                }
            }
            ConsoleView.ShowMessage($"Name of garage: {garage.Name} | Capacity: {garage.Capacity} | Current count of cars: {garage.Vehicles.Count}");
            if (garage.FindByPlate("AAA-001") != null)
            {
                ConsoleView.ShowMessage("Found");
            }
            else
            {
                ConsoleView.ShowMessage("Not Found");
            }
            if (garage.FindByPlate("AAA-011") != null)
            {
                ConsoleView.ShowMessage("Found");
            }
            else
            {
                ConsoleView.ShowMessage("Not Found");
            }
            if (garage.RemoveVehicle("AAA-001"))
            {
                ConsoleView.ShowMessage("Deleted succesfully");
            }
            else
            {
                ConsoleView.ShowMessage("Deletion failed");
            }
            if (garage.AddVehicle(vehicles[3]))
            {
                ConsoleView.ShowMessage("Successfully added vehicle to garage");
            }
            else
            {
                ConsoleView.ShowMessage("Garage is full");
            }
        }
    }
}
