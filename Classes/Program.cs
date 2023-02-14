namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Tacoma";
            myCar.Year = 2024;

            var ford = new Car()
            {
                Make = "Ford",
                Model = "Raptor",
                Year = 2023
            };

            var mercedes = new Car("Mercedes", "Sprinter", 2019);

            var carList = new List<Car>() { myCar, mercedes, ford };

            foreach(var vehicle in carList) 
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

        }

    }
}
