using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // The code provided will print ‘Hello World’ to the console.
    //        // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
    //        Console.WriteLine("Hello World!");
    //        Console.ReadKey();

    //        // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
    //    }
    //}

    //class Car
    //{
    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //    public string Size { get; set; }
    //    public double BasePrice { get; set; }
    //    public double OptionsPrice { get; set; }
    //    public double Tax { get; set; }

    //    public double CalculatePriceTotal()
    //    {
    //        double totalPrice = BasePrice + OptionsPrice;
    //        totalPrice += totalPrice * Tax;
    //        return totalPrice;

    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car()
    //        {
    //            Make = "JaguarHonda",
    //            Model = "Civic",
    //            Size = "9000",
    //            BasePrice = 90000,
    //            OptionsPrice = 0,
    //            Tax = 0.20
    //        };
    //        //car.OptionsPrice += 300; //(paint)
    //        //car.OptionsPrice += 200; //(warm seats)
    //        //car.OptionsPrice += 100; //(cameras

    //        double totalPrice = car.CalculatePriceTotal();
    //        Console.WriteLine("TotalPrice:" + totalPrice);
    //        Console.ReadKey();

    //    }
    //}

    //class CarPriceCalculator
    //{
    //    private double basePrice;
    //    private double optionsTotal = 0;
    //    private const double TAX_RATE = 0.20;


    //}

    class CarPricing
    {
        static void Main(string[]args)
        {
            int basePrice = 0;
            Console.WriteLine("Enter Car make:");
            string make = Console.ReadLine();
            Console.WriteLine("Enter model:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter size - small, big, large:");
            string size = Console.ReadLine();

            if(make == "ford" && model == "Mustang" && size == "big")
            {
                basePrice = 25000;
            }
           else if (make == "Honda" && model == "civic" && size == "big")
            {
                basePrice = 25000;
            }
            else
            {
                Console.WriteLine("Invalid car make or model or size");
                return;
            }

            //show the customer base price

            Console.WriteLine("Base Price :" + basePrice);

            Console.WriteLine("Do you want Metallic Paint? yes/no");
            string MetallicPaint = Console.ReadLine();
            Console.WriteLine("Do you want Heated Seats? yes/no");
            string HeatedSeats = Console.ReadLine();
            Console.WriteLine("Do you want reverse camera? yes/no");
            string ReversingCamera = Console.ReadLine();

            if(MetallicPaint == "yes")
            {
                basePrice += 300;
            
            }
            if (HeatedSeats == "yes")
            {
                basePrice += 200;

            }
            if (ReversingCamera == "yes")
            {
                basePrice += 100;

            }
            double tax = basePrice * 0.2;
            double totalPrice = basePrice + tax;

            Console.WriteLine("Total Price GP:" + totalPrice);
            Console.ReadKey();


        }
    }
  
}
