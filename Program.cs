using System;

namespace Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк, которые хотите использовать");
            int n = int.Parse(Console.ReadLine());
            string[] vs = new string[n];
            string input2 = null;
            while (input2 != "X")
            {
                input2 = Console.ReadLine();
                for (int i = 0; i< vs.Length; i++)
                {
                    vs[i] = input2;
                }
            }

            Console.WriteLine("=========================");

            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }


            Console.ReadKey();

        }
    }
}
