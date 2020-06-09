using System;
using System.Collections.Generic;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://open.kattis.com/problems/tarifa
            
            var firstString = Console.ReadLine();
            var firstNumber = SimpleConverter(firstString);

            var secondString = Console.ReadLine();
            var secondNumber = SimpleConverter(secondString);

            string[] thirdStrings = new string[secondNumber];
            int[] thirdNums = new int[secondNumber];

            for (int i = 0; i < thirdStrings.Length; i++)
            {
                thirdStrings[i] = Console.ReadLine();
                thirdNums[i] = ArrayItemConverter(thirdStrings[i], firstNumber, secondNumber);
            }

            var thirdSum = ArraySum(thirdNums);
            var result = NextMonth(firstNumber, secondNumber, thirdSum);

            Console.WriteLine(result);
        }

        private static int NextMonth(int a, int b, int s)
        {
            return (a * (b + 1) - s);
        }

        private static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        private static int[] ZeroArray(int leng)
        {
            int[] myArr = new int[leng];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = 0;
            }
            return myArr;
        }

        private static int ArrayItemConverter(string str, int max, int leng)
        {
            int num = 0;

            try
            {
                num = int.Parse(str);

                    if ((num < 0) || (num > max))
                        throw new ArgumentException(); 
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("FormatException !!!!");
                str = Console.ReadLine();
                num = ArrayItemConverter(str, max, leng);
                return num;
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.WriteLine("IndexOutOfRangeException !!!!");
                str = Console.ReadLine();
                num = ArrayItemConverter(str, max, leng);
                return num;
            }
            catch (ArgumentException ex3)
            {
                Console.WriteLine(ex3.Message);
                Console.WriteLine("IndexOutOfRangeException !!!!");
                str = Console.ReadLine();
                ArrayItemConverter(str, max, leng);
                return num;
            }

            return num;
        }

        private static int SimpleConverter(string str)
        {
            int num = 0;

            try
            {
                num = int.Parse(str);

                if ((num <= 0) || (num > 100))
                    throw new ArgumentException();
            }

            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("FormatException !!!!");
                str = Console.ReadLine();
                num = SimpleConverter(str);
                return num;
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.WriteLine("IndexOutOfRangeException !!!!");
                str = Console.ReadLine();
                num = SimpleConverter(str);
                return num;
            }
            catch (ArgumentException ex3)
            {
                Console.WriteLine(ex3.Message);
                Console.WriteLine("IndexOutOfRangeException !!!!");
                str = Console.ReadLine();
                num = SimpleConverter(str);
                return num;
            }
            return num;
        }
    }
}
