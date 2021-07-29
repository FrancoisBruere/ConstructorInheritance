namespace ConstructorInheritance
{
    public class Car : Vehicle
    {
     
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            System.Console.WriteLine("car is being initialized {0}",registrationNumber);
        }

    }
}
