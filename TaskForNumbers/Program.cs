using System;

namespace TaskForNumbers
{
    class Program
    {
        static void Main(string[] args)
        {                                           
            int n = 17, m = 100;                   
            for (n=17; n <m; n++)                   
            {
                if (n % 7 == 0) 
                {
                    Console.WriteLine(n);
                }



            }
        
        }
    }
}
