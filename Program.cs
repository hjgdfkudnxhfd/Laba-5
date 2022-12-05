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

        static bool NumCharOrNot(string num)
        {
            char a;
            if (char.TryParse(num, out a))
                return true;
            return false;
        }

        static bool NumIntOrNotWithoutTryParse(string num)
        {
            foreach (char c in num.ToCharArray())
            {
                if (!(((int)c > 47) && ((int)c < 58)))
                {
                    return false;
                }
            }
            return true;
        }

        static string AreTheNumsEqual(int numInt, float numFl1, float numFl2)
        {

            if ((numFl1 == numFl2) && (numFl1 == numInt))
                return ($"Все числа типов INT и FLOAT равны ({numInt} = {numFl1} = {numFl2})");
            else if (numFl1 == numFl2)
                return ($"Числа FLOAT равны ({numFl1} = {numFl2})");
            else if (numFl1 == numInt)
                return ($"Первое число FLOAT и число INT равны ({numFl1} = {numInt})");
            else if (numFl2 == numInt)
                return ($"Второе число FLOAT и число INT равны ({numFl2} = {numInt})");
            else
                return ($"Числа {numInt}, {numFl1}, {numFl2} не равны между собой");
        }

        static void Task1()
        {
            Console.Clear();
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

        static int Summation(string strNum)
        {
            int sum = 0;
            foreach (char c in strNum)
            {
                switch (c)
                {
                    case '1':
                        sum += 1;
                        break;
                    case '2':
                        sum += 2;
                        break;
                    case '3':
                        sum += 3;
                        break;
                    case '4':
                        sum += 4;
                        break;
                    case '5':
                        sum += 5;
                        break;
                    case '6':
                        sum += 6;
                        break;
                    case '7':
                        sum += 7;
                        break;
                    case '8':
                        sum += 8;
                        break;
                    case '9':
                        sum += 9;
                        break;
                    default: 
                        break;
                }
            }
            return sum;
        }

        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Введите целочисленное число: ");
            string strNum = Console.ReadLine();

            bool minus = false;
            if (strNum[0] == '-')
            {
                strNum = strNum.Substring(1);
                minus = true;
            }

            bool flag = NumIntOrNotWithoutTryParse(strNum);
            int sum = 0;
            if (flag)
            {
                sum = Summation(strNum);
                if (minus)
                    strNum = "-" + strNum;
                Console.WriteLine($"Сумма цифр числа {strNum} = {sum}");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Некорректный ввод числа ");
                Console.ReadKey();
            }
        }

        static void Task3()
        {
            Console.Clear();
            int numInt; //первая часть
            float numFloat;
            char numChar;

            string strInt;
            string strFloat;
            string strChar;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ПЕРВЫЙ НОМЕР ");
                Console.WriteLine("Введите число INT");
                strInt = Console.ReadLine();
                Console.WriteLine("Введите число FLOAT");
                strFloat = Console.ReadLine();
                Console.WriteLine("Введите символ CHAR");
                strChar = Console.ReadLine();
                Console.Clear();
                if ((NumIntOrNot(strInt)) && (NumFloatOrNot(strFloat)) && (NumCharOrNot(strChar)))
                {
                    numInt = Convert.ToInt32(strInt);
                    numFloat = Convert.ToSingle(strFloat);
                    numChar = Convert.ToChar(strChar);
                    Console.WriteLine($"Ввод корректный, ваши числа: \n" +
                                      $"INT: {strInt}\n" +
                                      $"FLOAT: {strFloat}\n" +
                                      $"CHAR: {strChar}");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите ввод");
                    Thread.Sleep(1600);
                }
            }

            strInt = ""; //вторая часть
            string strFloat1;
            string strFloat2;

            numInt = 0;
            float numFloat1;
            float numFloat2;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВТОРОЙ НОМЕР ");
                Console.WriteLine("Введите число INT");
                strInt = Console.ReadLine();
                Console.WriteLine("Введите первое число FLOAT");
                strFloat1 = Console.ReadLine();
                Console.WriteLine("Введите второе число FLOAT");
                strFloat2 = Console.ReadLine();

                if ((NumIntOrNot(strInt)) && (NumFloatOrNot(strFloat1)) && (NumFloatOrNot(strFloat2)))
                {
                    numInt = Convert.ToInt32(strInt);
                    numFloat1 = Convert.ToSingle(strFloat1);
                    numFloat2 = Convert.ToSingle(strFloat2);
                    Console.WriteLine(AreTheNumsEqual(numInt, numFloat1, numFloat2));
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите ввод");
                    Thread.Sleep(1600);
                }
            }

            strInt = "";     //третья часть
            strFloat = "";
            numInt = 0;
            numFloat = 0;
            bool flag = false;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ТРЕТИЙ НОМЕР ");
                Console.WriteLine("Введите число INT");
                strInt = Console.ReadLine();
                Console.WriteLine("Введите число FLOAT");
                strFloat = Console.ReadLine();
                if ((NumIntOrNot(strInt)) && (NumFloatOrNot(strFloat)))
                {
                    numInt = Convert.ToInt32(strInt);
                    numFloat = Convert.ToSingle(strFloat);
                    flag = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите ввод");
                    Thread.Sleep(1600);
                }
            }
            var sum = numInt + numFloat;
            if (flag)
            {
                Console.WriteLine($"Ваша сумма {numInt} + {numFloat} = {sum} (тип float)");
                Console.ReadKey();
            }


        }

        static void Main(string[] args)
        {
            Task3();
        }
    }
}
