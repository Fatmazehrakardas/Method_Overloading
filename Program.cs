using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // out 
            string number = "999";
            int outNumber;
            bool result = int.TryParse(number, out outNumber);
            if (result)
            {
                Console.WriteLine("Successful!");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Unsuccessful!");
            }
            Methods methods = new Methods();
            methods.Sum(4, 5, out int sumres);
            Console.WriteLine(sumres);

            // Overloading
            int str = 999;
            //methods.PrintScreen(Convert.ToString(str)); After Overloading no need
            methods.PrintScreen(str);
            methods.PrintScreen("Fatma", "Zehra");

            // Signature of Method
            // --Method Name+ Number of Parameters+ Type of Parameters
            // --Access level not Signature of Method
            // --A return type of a method is not part of the signature of the method
            // for the purposes of method overloading.

        }
    }
    class Methods
    {
        
        public void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        public void PrintScreen(string data)
        {
            Console.WriteLine(data);
        }
        public void PrintScreen(int data)
        {
            Console.WriteLine(data);
        }
        public void PrintScreen(string data1, string data2)
        {
            Console.WriteLine(data1 + data2);
        }
    }
}
