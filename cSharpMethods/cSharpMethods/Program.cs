using System;

namespace cSharpMethods
{

    class Program
    {
        static void Main(string[] args)
        {
            Program program=new Program();
            program.EvenNumbers();
            Program.oddNumbers();

        }
        public void EvenNumbers()
        {
            int start = 0;
            while(start < 10)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        public static void oddNumbers()
        {
            int start = 1;
            while(start <=10)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }

}