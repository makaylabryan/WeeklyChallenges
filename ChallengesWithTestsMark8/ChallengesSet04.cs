using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else if (number % 2 == 1)
                {
                    sum -= number;
                }
                else return 0;
            }
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var numList = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return numList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
           return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                );
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number) ;
           
            return isNumber;
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var elementsNum = objs.Length;
            var majority = (elementsNum / 2) + 1;

            var count = 0;
            foreach ( var obj in objs ) 
            {
                if (obj == null)
                {
                    count++;
                }
            }
            if (count >= majority)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            { return 0; }

            var evenNums = numbers.Where(nums => nums % 2 == 0);

            if (numbers.Count() == 0)
            { return 0; }

            if (evenNums.Count() == 0)
            { return 0; }

                       
            return evenNums.Average();
            
        }

        public int Factorial(int number)
        {
            var factorial = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
