using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            
            float floatNum1 = float.NaN;
            float floatNum2;
            while (true)
            {
                Console.WriteLine("Задание 1. Для выхода нажмите 'q' ");
                Console.WriteLine("Введи число: ");
                string strNum = Console.ReadLine();
                if (NumIntOrNot(strNum))
                {
                    Console.WriteLine((char)Convert.ToInt32(strNum));
                    Console.ReadKey();
                }
                else if (NumFloatOrNot(strNum))
                {
                    floatNum2 = Convert.ToSingle(strNum);
                    if (floatNum2 == floatNum1)
                    {
                        Console.WriteLine("Введеные числа равны, выход");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.Write("Повторите ввод числа");
                        floatNum1 = floatNum2;
                        Thread.Sleep(1000);


                    }
                }
                else if (strNum == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, повторите попытку");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    
        static void Main(string[] args)
        {
            Task1();
        }
    }
}
