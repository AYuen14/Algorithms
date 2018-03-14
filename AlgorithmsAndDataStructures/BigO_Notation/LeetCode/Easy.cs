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
