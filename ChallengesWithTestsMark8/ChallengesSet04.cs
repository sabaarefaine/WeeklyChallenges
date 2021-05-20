using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var even = 0;
            var odd = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    even += item;
                }
                else
                {
                    odd -= item;
                }
            }

            return even + odd;

            //return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

            //return numbers.Sum(x => x *(int)Math.Pow(-1, x % 2));
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //create new list to add strings to
            List<string> stringList = new List<string>();

            stringList.Add(str1);
            stringList.Add(str2);
            stringList.Add(str3);
            stringList.Add(str4);

            //list to array to get length
            string[] str = stringList.ToArray();

            return str.Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>();

            intList.Add(number1);
            intList.Add(number2);
            intList.Add(number3);
            intList.Add(number4);

            return intList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }

            //shout out to stack overflow
            if (double.TryParse(input, out _))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullVals = 0;

            foreach (var val in objs)
            {
                if (val == null )
                {
                    nullVals++;
                }
            }

            return nullVals > (objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
            {
                return 0;
            }

            double total = 0;
            int count = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            return total / count;
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int total = 1;

            while (number != 1)
            {
                total *= number;
                number--;
            }
            return total; 
           
        }
    }
}
