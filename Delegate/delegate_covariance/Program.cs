using System.Diagnostics.Tracing;

namespace delegate_covariance
{

    public static class CarFactory
    {
        public static ICECar ReturnICECar(int id, string name)
        {
            return new ICECar { Id = id, Name = name };
        }

        public static EVCar ReturnEvCar(int id, string name)
        {
            return new EVCar { Id = id, Name = name };
        }
    }

    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string GetCarDetails()
        {
            return $"{Id} - {Name}";
        }
    }

    public class ICECar:Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} - Internal Combustion Engine";
        }
    }

    public class EVCar : Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} - Electric";
        }
    }

    internal class Program
    {
        delegate Car CarFactoryDel(int id, string name);

        static void Main(string[] args)
        {
            CarFactoryDel carFactoryDel = 
        }
    }
}