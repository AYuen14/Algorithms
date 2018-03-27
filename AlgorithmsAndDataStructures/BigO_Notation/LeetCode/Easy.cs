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
            int[] array = new int[] { 0, 1, 0, 3, 12 };
            //MoveZeroes(array);

            //IList<string> output = LetterCasePermutation("a1b2");
            int output = RotatedDigits(857);
        }

        public int RotatedDigits(int N)
        {
            int counter = 0;

            for (int i = 1; i <= N; i++)
            {
                bool isRotated = false;
                int x = i;
                if(i ==32)
                {
                    int w = i;
                }
                while(x != 0)
                {
                    int digit = x % 10;
                    x = x / 10;

                    bool isExit = false;

                    switch (digit)
                    {
                        case 3:
                        case 4:
                        case 7:
                            isExit = true;
                            isRotated = false;
                            break;

                        case 2:
                        case 5:
                        case 6:
                        case 9:
                            isRotated = true;
                            break;
                    }

                    if(isExit)
                    {
                        break;
                    }          
                }

                if (isRotated)
                {
                    counter++;
                }
            }

            return counter;
        }

        private bool isGood(int n)
        {
            bool isNewNumber = false; // True if n contains a 2, 5, 6, or 9
            do
            {
                int digit = n % 10;  // Gets the least significant digit (i.e. one's place)
                switch (digit)
                {
                    case 3:
                    case 4:
                    case 7:
                        return false; // Digit is a 3, 4, or 7 (i.e. contains an invalid rotation)
                    case 2:
                    case 5:
                    case 6:
                    case 9:
                        isNewNumber = true; // Digit is a 2, 5, 6, or 9 (i.e. 'good' number)
                        break;
                }
                n /= 10;  // Shift decimal digits right 1
            } while (n != 0);

            return isNewNumber;
        }

        public IList<string> LetterCasePermutation(string S)
        {
            List<string> output = new List<string>();
            char[] input = S.ToCharArray();

            for(int i = 0; i <= input.Length-1;i++)
            {
                if(!char.IsNumber(input[i]))
                {
                    StringBuilder lower = new StringBuilder();
                    StringBuilder upper = new StringBuilder();

                    for (int y = 0; y <= input.Length-1;y++)
                    {
                        if(input[y] != input[i])
                        {
                            lower.Append(input[y]);
                            upper.Append(input[y]);
                        }
                        else
                        {
                            lower.Append(input[y].ToString().ToLower());
                            upper.Append(input[y].ToString().ToUpper());
                        }

                    }

                    output.Add(lower.ToString());
                    output.Add(upper.ToString());
                }
            }

            return output;
        }

        /// <summary>
        /// You're given strings J representing the types of stones that are jewels, and S representing the stones you have.
        /// Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
        /// Example:
        /// Input: J = "aA", S = "aAAbbbb"
        /// Output: 3
        /// </summary>
        /// <param name="J">The j.</param>
        /// <param name="S">The s.</param>
        /// <returns></returns>
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

        public void MoveZeroes(int[] nums)
        {
            int counter = 0;;

            for (int i=0; i < nums.Length;i++)
            {
                               
                if (nums[i] != 0)
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }

            for(int i = counter; i< nums.Length;i++)
            {
                nums[i] = 0;
            }

            var n = nums;
        }

        public int[] CalculateTwoSum(int[] number, int target)
        {
            int[] output = null;

            if (number.Length - 1 > 0)
            {
                for (int i = 0; i <= number.Length - 1; i++)
                {
                    for (int x = 0; x <= number.Length - 1; x++)
                    {
                        if (i != x && number[i] + number[x] == target)
                        {
                            output = new int[2];
                            output[0] = i;
                            output[1] = x;
                            break;
                        }
                    }
                    if (output != null)
                    {
                        break;
                    }
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
        /// <param name="moves">The moves.</param>
        /// <returns></returns>
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
    }
}
