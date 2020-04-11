using System;

namespace conditional_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num=1;
            while (num<6)
            {
                Console.WriteLine(num);
                num++;
            }
            int x=0;
            while(++x<6){
                Console.WriteLine(x);
            }
        }
    }
}
