using System;

namespace LabExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // do-while checks the condition at the end
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            Console.ReadLine();
        }
    }
}