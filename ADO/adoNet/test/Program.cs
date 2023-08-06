namespace test
{
    internal class Program
    {
        class Car
        {
            //public string carName;
            private static int id;
            public int CarId
            {
                get { return id; }
            }

            public Car()
            {
                id++;
            }

            public void Start()
            {
                Console.WriteLine($"{this.CarId} start");
            }
            public void Stop(string name)
            {
                Console.WriteLine($"{name} stop");
            }
        }

        class Bus : Car
        {
            public string busName;
            public Bus(string busName)
            {
                this.busName = busName;
            }
            public void Start()
            {
                Console.WriteLine($"{this.CarId} start");
            }
            public void Stop()
            {
                Console.WriteLine($"{this.busName} stop");
            }

        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Start();
            car.Stop("pika");

            Car car2 = new Car();
            car2.Start();

            Bus bus = new Bus("159");
            bus.Start();

            Car car3 = new Car();
            //car3.CarId = 999;
            car3.Start();
        }
    }
}