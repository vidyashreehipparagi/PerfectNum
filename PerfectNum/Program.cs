using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<num;i++)
            {
                //rem = num % 10;
                if (num%i==0)             //num=6    i=1  i<num      num%i    sum=sum+i
                {                              //         1<6=0        6%1=6    0=0+1=1  2
                                                //    i=2  2<6=0       
                    sum = sum + i;
                }
                
            }
            if(sum==num)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not perfect number"); 
            }
        }
    }
}
