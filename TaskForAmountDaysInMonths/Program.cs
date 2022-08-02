using System;

namespace TaskForAmountDaysInMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 28,b=30,c=31;           
            string month = "September";
            switch (month)
            {
                case "February":
                    Console.WriteLine(a + "or 29");
                 break;
                case "April":
                    Console.WriteLine(b);
                 break;
                case "June":
                    Console.WriteLine(b);
                    break;
                case "September":
                    Console.WriteLine(b);
                    break;
                case "November":
                    Console.WriteLine(b);
                    break;
                case "January":
                    Console.WriteLine(c);
                    break;
                case "March":
                    Console.WriteLine(c);
                    break;
                case "May":
                    Console.WriteLine(c);
                    break;
                case "Jule":
                    Console.WriteLine(c);
                    break;
                case "August":
                    Console.WriteLine(c);
                    break;
                case "December":
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("Error input is wrong");
                    break;



            }
        }
    }
}
