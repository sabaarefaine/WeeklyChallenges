using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i< businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1 )
            {
                return false;
            }

            //-1 to look at index
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;

            if (numbers == null || numbers.Length < 1)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0) 
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            //well this didn't work lol
            string sentence = string.Join(", ", words);

            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }

            List<double> fourthElement = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElement.Add(elements[i]);
            }
            return fourthElement.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
