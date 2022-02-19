using System;

namespace sandbox
{
    public class Program
    {
        public static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            showCar();
        }

        public static void showCar()
        {
            var wwId3 = new Car("Volkswagen", "ID3", 4, 72, 0);
            var peugot307 = new Car("Peugeot", "307", 2, 100, 1000);
            var number = 7;
            Console.WriteLine(wwId3.brandName);
            Console.WriteLine(peugot307.brandName);

            wwId3.mileageAmount = 10;
            Console.WriteLine(wwId3.mileageAmount);

            var changeby = 15;
            wwId3.increaseMilage(changeby); // 'this' points to wwId3
            //peugot307.increaseMilage(changeby); // 'this' points to peugeot307

            //increaseMilage2(peugot307, changeby);
            Console.WriteLine(wwId3.mileageAmount);

            var carisNew = peugot307.isNew();
            Console.WriteLine(peugot307.mileageAmount + " " + carisNew);
            peugot307.increaseMilage(30);

            carisNew = peugot307.isNew();
            Console.WriteLine(peugot307.mileageAmount + " " + carisNew);


        }


        //public static void increaseMilage2(Car car, int changeby)
        //{
        //    car.mileageAmount = car.mileageAmount + changeby;

        //}

    }
}



