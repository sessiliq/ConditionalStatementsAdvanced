namespace FruitShop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (
                (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "grapes" || fruit == "kiwi" || fruit == "pineapple") 
                && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday"))
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    if (fruit == "banana")
                    {
                        Console.WriteLine("{0:F2}", quantity * 2.5);
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine("{0:F2}", quantity * 1.2);
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine("{0:F2}", quantity * 0.85);
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine("{0:F2}", quantity * 1.45);
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine("{0:F2}", quantity * 2.7);
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine("{0:F2}", quantity * 5.5);
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine("{0:F2}", quantity * 3.85);
                    }
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    if (fruit == "banana")
                    {
                        Console.WriteLine("{0:F2}", quantity * 2.7);
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine("{0:F2}", quantity * 1.25);
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine("{0:F2}", quantity * 0.90);
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine("{0:F2}", quantity * 1.60);
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine("{0:F2}", quantity * 3);
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine("{0:F2}", quantity * 5.6);
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine("{0:F2}", quantity * 4.2);
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
