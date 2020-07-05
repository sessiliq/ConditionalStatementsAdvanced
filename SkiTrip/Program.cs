namespace SkiTrip
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;

            if (room == "room for one person")
            {
                price = (days - 1) * 18;
            }
            else if (room == "apartment")
            {
                if (days < 10)
                {
                    price = ((days - 1) * 25) * (1 - 0.3);
                }
                else if (days > 10 && days < 15)
                {
                    price = ((days - 1) * 25) * (1 - 0.35);
                }
                else if (days > 15)
                {
                    price = ((days - 1) * 25) * (1 - 0.5);
                }
            }
            else if (room == "president apartment")
            {
                if (days < 10)
                {
                    price = ((days - 1) * 35) * (1 - 0.1);
                }
                else if (days > 10 && days < 15)
                {
                    price = ((days - 1) * 35) * (1 - 0.15);
                }
                else if (days > 15)
                {
                    price = ((days - 1) * 35) * (1 - 0.2);
                }
            }
            if (rating == "positive")
            {
                Console.WriteLine("{0:F2}", price * (1 + 0.25));
            }
            else if (rating == "negative")
            {
                Console.WriteLine("{0:F2}", price * (1 - 0.1));
            }
        }
    }
}
