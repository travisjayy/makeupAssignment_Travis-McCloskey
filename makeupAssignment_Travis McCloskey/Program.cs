using System;

namespace makeupAssignment_Travis_McCloskey
{
    class Program
    {
        static void CopyMethod()
        {
            Console.WriteLine("Hello and welcome to Travis McCloskey's | Version = 36 | assignment!");
            Console.WriteLine("Please input any word and watch this program repeat it!");
            string wordsPersonTyped;
            wordsPersonTyped = Console.ReadLine();
            Console.WriteLine("Thank you! Now please input how many times you would like the word to be repeated: input a number from 3 t0 6!");
            int numberPersonTyped = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberPersonTyped +1; i++)
            {
                Console.WriteLine(wordsPersonTyped);
            }
        }
        static void Main(string[] args)
        {
            CopyMethod();
        }
    }
}
