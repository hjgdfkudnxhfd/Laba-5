using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5_Valeeva_PrI102
{
    internal class Program
    {
        static bool NumFloatOrNot(string num)
        {
            float a;
            if (float.TryParse(num, out a))
                return true;
            return false;
        }

        static bool NumIntOrNot(string num)
        {
            int a;
            if (int.TryParse(num, out a))
                return true;
            return false;
        }

        static void Task1()
        {
            Console.WriteLine("Введи число");
            string strNum = Console.ReadLine();
            int intNum;
            float floatNum;
            if (NumIntOrNot(strNum))
            {
                Console.WriteLine((char)Convert.ToInt32(strNum));
            }

        }

        static void Main(string[] args)
        {
            Task1();
        }
    }
}
