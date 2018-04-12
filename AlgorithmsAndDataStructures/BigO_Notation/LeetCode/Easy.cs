using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.LeetCode
{
    public class Easy
    {

        public Easy()
        {
            int candies = AddDigits(38);
        }

        public int AddDigits(int num)
        {
            while(num > 10)
            {
                int total = 0;
                char[] charArray = num.ToString().ToCharArray();

                for(int i = 0; i <= charArray.Length-1;i++)
                {
                    total += int.Parse(charArray[i].ToString());
                }

                num = total;
            }

            return num;
        }

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int output = 0;
            int count = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if(nums[i] == 1)
                {
                    count++;
                }
                else
                {                  
                    count = 0;
                }

                if (count > output)
                {
                    output = count;
                }
                
            }

            return output;
        }

        public int SingleNumber(int[] nums)
        {
            int output = 0;
            Hashtable distinctNumber = new Hashtable();

            for(int i=0; i <= nums.Length-1;i ++)
            {
                if (!distinctNumber.ContainsKey(nums[i]))
                {
                    distinctNumber.Add(nums[i], 1);
                }
                else
                {
                    distinctNumber[nums[i]] = int.Parse(distinctNumber[nums[i]].ToString()) + 1;
                }
            }

            foreach(DictionaryEntry de in distinctNumber)
            {
                if(int.Parse(de.Value.ToString()) == 1)
                {
                    output = int.Parse(de.Key.ToString());
                    break;
                }
            }

            return output;
        }

        public int DistributeCandies(int[] candies)
        {
            Hashtable distinctCandies = new Hashtable();
            int output = 0;

            for(int i = 0; i <= candies.Length-1;i++)
            {
                if(!distinctCandies.ContainsKey(candies[i]))
                {
                    distinctCandies.Add(candies[i], 1);
                }
            }

            int sister = distinctCandies.Count;
            int brother = candies.Length - sister;

            int difference = sister - brother;

            if(difference <= 0)
            {
                output = sister;
            }
            else
            {
                output = sister - (difference / 2);
            }

            return output;
        }

        public string[] FindWordsOnKeyboardRow(string[] words)
        {
            HashSet<char> row1 = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            HashSet<char> row2 = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            HashSet<char> row3 = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            List<string> output = new List<string>();

            foreach(string s in words)
            {
                if(doesContain(s,row1) || doesContain(s, row2) || doesContain(s, row3))
                {
                    output.Add(s);
                }
            }

            return output.ToArray();
        }

        private bool doesContain(string word, HashSet<char> rows)
        {
            bool isContain = false;

            if(!string.IsNullOrWhiteSpace(word))
            {
                char[] array = word.ToCharArray();

                for(int i = 0; i <= array.Length-1;i++)
                {
                    if(!rows.Contains(Convert.ToChar(array[i].ToString().ToLower())))
                    {
                        return false;
                    }
                }

                isContain = true;
            }

            return isContain;
        }


        private bool IsPalindrome(string input)
        {
            try
            {
                char[] arrayofchars = input.ToArray();
                int first = 0;
                int last = arrayofchars.Length - 1;
                while(true)
                {
                    if(first > last)
                    {
                        return true;
                    }
                    if(arrayofchars[first] != arrayofchars[last])
                    {
                        return false;
                    }

                    first++;
                    last--;
                }

            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] array = s.Split(' ');

            for(int i =0; i <= array.Length-1;i++)
            {
                char[] charArray = array[i].ToCharArray();
                int first = 0;
                int last = charArray.Length - 1;

                while(first< last)
                {
                    char temp = charArray[first];
                    charArray[first] = charArray[last];
                    charArray[last] = temp;

                    first++;
                    last--;
                }
                sb.Append(charArray);
                sb.Append(' ');
            }

            return sb.ToString().TrimEnd(' ');
        }


        /// <summary>
        /// Moves the zeroes to end of array.
        /// Must be in place without making copy
        /// </summary>
        /// <param name="nums">The nums.</param>
        public void MoveZeroes(int[] nums)
        {
            int first = 0;
            int last = nums.Length - 1;
            while(first < last)
            {
                int pivot = first;
                while(pivot < last && nums[pivot] == 0)
                {
                    int temp = nums[pivot];
                    nums[pivot] = nums[pivot + 1];
                    nums[pivot + 1] = temp;
                    pivot++;
                }
                if (nums[first] == 0)
                {
                    int temp = nums[first];
                    nums[first] = nums[first + 1];
                    nums[first + 1] = temp;
                }
                first++;
            }

            var n = nums;
        }


        /// <summary>
        /// You're given strings J representing the types of stones that are jewels, and S representing the stones you have.
        /// Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
        /// Example:
        /// Input: J = "aA", S = "aAAbbbb"
        /// Output: 3
        /// </summary>
        public int NumJewelsInStones(string J, string S)
        {
            int output = 0;
            char[] jewels = J.ToCharArray();
            char[] stones = S.ToCharArray();
            Hashtable jewelHashTable = new Hashtable();

            for(int i = 0; i < jewels.Length; i++)
            {
                jewelHashTable.Add(jewels[i], 0);
            }

            for(int i = 0; i < stones.Length; i++)
            {
                if(jewelHashTable.ContainsKey(stones[i]))
                {
                    output++;
                }
            }

            return output;
        }

        /// <summary>
        /// Initially, there is a Robot at position (0, 0). Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
        ///The move sequence is represented by a string. And each move is represent by a character.The valid robot moves are R (Right), L(Left), U(Up) and D(down). 
        ///The output should be true or false representing whether the robot makes a circle.
        ///
        /// Example1:
        /// Input: "UD"
        /// Output: true
        /// 
        /// Exmaple2:
        /// Input: "LL"
        /// Output: false
        /// </summary>
        public bool JudgeCircle(string moves)
        {
            bool isCircle = false;

            if(!string.IsNullOrEmpty(moves))
            {
                int countUp = 0,
                    countDown = 0,
                    countLeft = 0,
                    countRight = 0;

                char[] moveSequence = moves.ToCharArray();

                for (int i = 0; i < moveSequence.Length; i++)
                {
                    switch (moveSequence[i])
                    {
                        case 'U':
                            countUp++;
                            break;
                        case 'D':
                            countDown++;
                            break;
                        case 'L':
                            countLeft++;
                            break;
                        case 'R':
                            countRight++;
                            break;
                    }
                }

                if(countUp - countDown == 0 && countLeft - countRight == 0)
                {
                    isCircle = true;
                }
            }

            return isCircle;
        }
        /// <summary>
        /// A shift on A consists of taking string A and moving the leftmost character to the rightmost position. 
        /// For example, if A = 'abcde', then it will be 'bcdea' after one shift on A. Return True if and only if A can become B after some number of shifts on A.
        /// 
        /// Example 1:
        ///Input: A = 'abcde', B = 'cdeab'
        ///Output: true
        ///Example 2:
        ///Input: A = 'abcde', B = 'abced'
        ///Output: false
        /// </summary>
        public bool RotateString(string A, string B)
        {
            bool isRotated = false;

            if (A.Length == B.Length)
            {
                var temp = new StringBuilder();
                temp.Append(A);

                for (int i = 0; i < A.Length; i++)
                {
                    temp.Remove(0, 1);
                    temp.Append(A[i]);

                    if (temp.ToString() == B)
                    {
                        isRotated = true;
                    }
                }
            }

            return isRotated;
        }

        /// <summary>
        /// TODO:
        /// A self-dividing number is a number that is divisible by every digit it contains.
        ///For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
        ///Also, a self-dividing number is not allowed to contain the digit zero.
        ///Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
        ///Input: 
        ///left = 1, right = 22
        ///Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
        /// </summary>
        public List<int> SelfDividingNumbers(int left, int right)
        {
            List<int> output = new List<int>();
            if(left > 0 && right <= 10000)
            {
                int index = 1;

                while(left <=right)
                {
                    if(left % index == 0)
                    {
                        output.Add(left);
                    }
                    index++;
                    left++;
                }
            }

            return output;
        }
    }
}
