namespace HomeTask10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1, "BMW", 300, "BM10001");
            Car car2 = new Car(2, "Mercedes", 340, "ME1002");
            Car car3 = new Car(3, "Lexus", 270, "LX10003");

            Gallery gallery1 = new Gallery();
            gallery1.AddCar(car1);
            gallery1.AddCar(car2);
            gallery1.AddCar(car3);

            //gallery1.ShowAllCars();

            //Car[] Wanted = gallery1.GetAllCars();
            //foreach (Car car in Wanted)
            //{
            //    Console.WriteLine(car.Name);
            //}


            //var Wanted2 = gallery1.FindCarById(3);
            //Console.WriteLine(Wanted2.Name);


            //var Wanted3 = gallery1.FindCarByCarCode("Me1002");
            //Console.WriteLine(Wanted3.ID);


            //Car[] Wanted3 = gallery1.FindCarBySpeedInterval(150, 300);
            //foreach (Car ithem in Wanted3)
            //{
            //    Console.WriteLine(ithem.Name);
            //}
        }
    }
}
