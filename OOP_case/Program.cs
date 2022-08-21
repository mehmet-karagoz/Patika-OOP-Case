// See https://aka.ms/new-console-template for more information


using OOP_case;

class Program
{
    public static void Main()
    {
        Car car = new Car()
        {
            LicensePlate = "ABC-123",
            OwnerFirstName = "John",
            OwnerLastName = "Doe",
            Balance = 1000,
            HGSNumber = 123
        };
        Minibus minibus = new Minibus()
        {
            LicensePlate = "123-123",
            OwnerFirstName = "Doe",
            OwnerLastName = "Doe",
            Balance = 1000,
            HGSNumber = 234
        };
        Bus bus = new Bus()
        {
            LicensePlate = "456-123",
            OwnerFirstName = "John",
            OwnerLastName = "John",
            Balance = 1000,
            HGSNumber = 345
        };

        BoxOffice boxOffice = new BoxOffice();
        DateTime now = DateTime.Now;
        boxOffice.PassVehicle(car,now);
        boxOffice.PassVehicle(minibus, now.AddMinutes(25));
        boxOffice.PassVehicle(bus, now.AddMinutes(55));

        Manager manager = new Manager(boxOffice);
        manager.PrintDailyBalance(now);
        boxOffice.PassedVehicles.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
    }
}