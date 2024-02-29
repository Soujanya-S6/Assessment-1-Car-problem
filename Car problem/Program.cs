using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Car_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sales information from April 1st to Sept 30th is:\n");
            int cust_total = 0;
            int retail_total = 0;
            int customer = 0;
            int retaill = 0;
            int[] apr = new int[3];
            apr= Calc(ref customer, ref retaill,0);
            int[] may=new int[3];
            may = Calc(ref customer, ref retaill, 1);
            int[] june = new int[3];
            june = Calc(ref customer, ref retaill, 0);
            int[] july = new int[3];
            july = Calc(ref customer, ref retaill, 1);
            int[] aug = new int[3];
            aug = Calc(ref customer, ref retaill, 1);
            int[] sept = new int[3];
            sept = Calc(ref customer, ref retaill, 0);
            cust_total += apr[0] + may[0] + june[0] + july[0] + aug[0] + sept[0];
            retail_total += apr[1] + may[1] + june[1] + july[1] + aug[1] + sept[1];
            Console.WriteLine($"Total Customer count: {cust_total}, Total Retail count: {retail_total}");
            Console.WriteLine("Number of vehicles sold each month:\n");
            Console.WriteLine($"April: {apr[2]}");
            Console.WriteLine($"May: {may[2]}");
            Console.WriteLine($"June: {june[2]}");
            Console.WriteLine($"July: {july[2]}");
            Console.WriteLine($"August: {aug[2]}");
            Console.WriteLine($"September: {sept[2]}");





        }
        public static int[] Calc(ref int cust, ref int retail,int month)
        {
            int[] days = new int[31];
            days[0] = 1;
            if (month == 1)
            {
                for (int n = 1; n <= 30; n++)
                {
                    int i = 1;
                    int r = 2;
                    days[i] = days[i - 1] + 2 * (r - 1);
                    r++;
                }
            }
            else if (month == 0)
            {
                for (int n = 1; n <= 29; n++)
                {
                    int i = 1;
                    int r = 2;
                    days[i] = days[i - 1] + 2 * (r - 1);
                    r++;
                }
                days[30] = 0;

            }
            cust = 0;
            retail = 1;
            if (month == 1)
            {
                for (int j = 1; j <= 31; j++)
                {
                    if (j % 5 == 0)
                    {
                        cust+=days[j];
                    }
                    else retail+=days[j];
                }
            }
            else if (month == 0)
            {
                for (int j = 1; j <= 30; j++)
                {
                    if (j % 5 == 0)
                    {
                        cust+=days[j];
                    }
                    else retail+=days[j];
                }

            }
            return new int[] { cust, retail, (cust+retail)};
        }
       
        
    }
}
