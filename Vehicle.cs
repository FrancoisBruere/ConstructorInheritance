namespace ConstructorInheritance
{
    public class Vehicle
    {

        private string _registrationNumber;

        //public Vehicle()
        //{
        //    System.Console.WriteLine("Vehicle is being initialized");
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("vehicle is being intitailized {0}",registrationNumber);
        }

    }
}
