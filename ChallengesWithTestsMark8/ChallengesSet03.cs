using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++) 
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Count() == 0)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isUpper = false;
            var isLower = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++) 
            {
                if (char.IsUpper(password[i])) 
                {
                    isUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }
            if (isUpper == true &&  isLower == true && isNumber == true) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            
            if (divisor == 0)
            {
                return 0;
            }
                                
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var lastNum = nums[nums.Length - 1];
            var firstNum = nums[0];
            return lastNum - firstNum;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
             
            for (int i = 0; i < 100; i++) 
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0;i < words.Length;i++) 
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
