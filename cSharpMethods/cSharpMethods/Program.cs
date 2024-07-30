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
            valParameter(15);
            int a = 15;
            refParameter(ref a);
            int sumResult = 0;
            outParameter(10, 20, out sumResult);
            Console.WriteLine("Out Parameter Sum: " + sumResult);
            paramArrayParameter(1,2,3);
            int[] param=new int[] {1,2,3,4};
            paramArrayParameter(param);

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
        public static void valParameter(int b)
        {
            
            Console.WriteLine("value parameter: " + b);
        }

        public static void refParameter(ref int b)
        {
            b = 20;
            Console.WriteLine("Ref Parameter:" + b);
        }
        public static void outParameter(int FN, int SN, out int Result)
        {
            Result = FN + SN;
        }

        public static void paramArrayParameter(params int[] param)
        {
            Console.WriteLine("Params Array Length: "+param.Length);
        }
    }

}