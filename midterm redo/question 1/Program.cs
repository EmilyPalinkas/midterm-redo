using System;


/// <summary>
/// Midterm Exam for MIS 3013 2020
/// </summary>
/// 
/// <author>
/// Emily Palinkas
/// </author>

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word >>");
            string answer1 = Console.ReadLine();

            Console.WriteLine("Enter a word >>");
            string answer2 = Console.ReadLine();

            int lettersword1 = 0, lettersword2 = 0;

            for (int i = 0; i < answer1.Length; i++)
            {
                lettersword1++;

            }

            for (int i = 0; i < answer2.Length; i++)
            {
                lettersword2++;
            }


            Console.WriteLine($"There are {lettersword1.ToString("0.0")} letters in the word {answer1}");

            Console.WriteLine($"There are {lettersword2.ToString("0.0")} letters in the word {answer2}");

            Console.WriteLine("We will subtract the number of letters in the smallest word from the number of letters in the largest word");


            int differenceinletters = 0;

            if (lettersword1 >= lettersword2)
            {
                differenceinletters = lettersword1 - lettersword2;
                Console.WriteLine($"{lettersword1.ToString("N1")} - {lettersword2.ToString("N1")} = {differenceinletters.ToString("N1")}");
            }
            else
            {
                differenceinletters = lettersword2 - lettersword1;
                Console.WriteLine($"{lettersword2.ToString("N1")} - {lettersword1.ToString("N1")} = {differenceinletters.ToString("N1")}");
            }




        }
    }
}
