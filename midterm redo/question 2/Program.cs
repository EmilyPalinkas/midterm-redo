using System;


/// <summary>
/// Midterm Exam for MIS 3013 2020
/// </summary>
/// 
/// <author>
/// Emily Palinkas
/// </author>
namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many coins do you have total?");
            string answer = Console.ReadLine();
            int numberofcoins;


            while (int.TryParse(answer, out numberofcoins) == false)
            {
                Console.WriteLine("please tell me the number of coins not fruit");
                answer = Console.ReadLine();
            }

            double Total = 0;

            for (int i = 0; i < numberofcoins; i++)
            {
                Console.WriteLine("What type of coin do you have?");
                string typecoin = Console.ReadLine().ToLower();

                if (typecoin == "penny")
                {
                    Total += 0.01;
                }

                if (typecoin == "nickel")
                {
                    Total += 0.05;
                }

                if (typecoin == "dime")
                {
                    Total += 0.10;
                }

                if (typecoin == "quarter")
                {
                    Total += 0.25;
                }

            }

            Console.WriteLine($"you have {Total.ToString("C4")} Total!");
        }
    }
}
