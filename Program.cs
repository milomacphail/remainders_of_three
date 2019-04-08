using System;

namespace _remainders
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int entryNumber = int.Parse(Console.ReadLine());

            int remainderNumber = 0;

            for(int i= 0; i < entryNumber; i++)
            {
                if (i%3 == 0)
                {
                    remainderNumber++;
                }
            }

            Console.WriteLine(remainderNumber);
        }
    }
}
