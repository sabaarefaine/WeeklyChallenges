using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
                return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
                return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double sum = 0;
            foreach (double num in numbers)
            {
                sum= numbers.Min() + numbers.Max();
            }
                return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
                return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var sum = 0;

            foreach (var item in numbers)
            {
                sum = (item % 2 == 0) ? sum + item : sum;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;

            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
