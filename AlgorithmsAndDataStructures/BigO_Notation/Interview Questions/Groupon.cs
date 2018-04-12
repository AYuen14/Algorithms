using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Interview_Questions
{
    public class Groupon
    {
        public Groupon()
        {
            string[] teststring = new string[] { "geeks", "are", "awesome" };
            char salt = '~';

            string x = SerializeString(teststring, salt);
            var y = DeserializeString(x, salt);
        }

        #region Find Element Appears Once
        public int FindElementAppearsOnce()
        {
            int[] input = new int[] { 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 };

            int output = input[0];
            Hashtable ArrayHashCount = new Hashtable();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!ArrayHashCount.ContainsKey(input[i]))
                {
                    ArrayHashCount.Add(input[i], 1);
                }
                else
                {
                    ArrayHashCount[input[i]] = int.Parse(ArrayHashCount[input[i]].ToString()) + 1;
                }
            }

            foreach (DictionaryEntry entry in ArrayHashCount)
            {
                if (entry.Value.ToString() == "1")
                {
                    output = int.Parse(entry.Key.ToString());
                }
            }

            return output;
        }
        #endregion

        #region Sort Array quick sort
        /// <summary>
        /// Sorts the array with only one and zero.
        /// </summary>
        /// <returns></returns>
        public void SortArrayWithOnlyOneAndZero()
        {
            //1 =7
            //0 = 6
            int[] Input = new int[] { 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1 };
            Input = new int[] { 1, 8, 21, 12, 56, 5, 8, 14, 7, 87, 43, 2, 3 };

            sort(Input, 0, Input.Length - 1);

            for (int i = 0; i <= Input.Length - 1; i++)
            {
                Console.WriteLine(Input[i]);
            }
        }

        private int[] sort(int[] array, int first, int last)
        {
            if (first < last)
            {
                int pivot = Partition(array, first, last);

                sort(array, first, pivot - 1);

                sort(array, pivot + 1, last);
            }
            return array;
        }

        private int Partition(int[] array, int first, int last)
        {

            int upCounter = first;
            int downCounter = last;

            if (upCounter < downCounter)
            {
                int pivot = array[first];

                while (upCounter < downCounter)
                {
                    while (upCounter < last && array[upCounter] <= pivot)
                    {
                        upCounter++;
                    }

                    while (downCounter > first && array[downCounter] > pivot)
                    {
                        downCounter--;
                    }

                    if (upCounter < downCounter)
                    {
                        //swap
                        Swap(array, upCounter, downCounter);
                    }
                }

                //swap
                Swap(array, first, downCounter);
            }

            return downCounter;
        }

        private void Swap(int[] array, int first, int last)
        {
            int temp2 = array[first];
            array[first] = array[last];
            array[last] = temp2;
        }
        #endregion

        #region Find First Non Repeating Character
        private void FindFirstNonRepeatingCharacter()
        {
            string input = "GeeksforGeeks";
            char output = new char();
            try
            {
                Hashtable hashTable = new Hashtable();
                char[] convertToArray = input.ToCharArray();

                for(int i = 0; i < convertToArray.Length-1;i++)
                {
                    if(hashTable.ContainsKey(convertToArray[i]))
                    {
                        hashTable[convertToArray[i]] = int.Parse(hashTable[convertToArray[i]].ToString()) + 1;
                    }
                    else
                    {
                        hashTable.Add(convertToArray[i], 1);
                    }
                }

                foreach(DictionaryEntry de in hashTable)
                {
                    if(int.Parse(de.Value.ToString()) == 1)
                    {
                        output = Convert.ToChar(de.Key.ToString());
                    }
                }

                var x = output;
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
        }
        #endregion

        #region Seriealize and Deserialize array of string
        private string SerializeString(string[] input, char salt)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i <= input.Length-1;i++)
            {
                string salted = string.Format("{0}{1}", input[i], salt);
                sb.Append(salted);
            }

            return sb.ToString().TrimEnd(salt);
        }

        private string[] DeserializeString(string input, char salt)
        {
            string[] output;

            output = input.Split(salt);

            return new string[0];
        }
        #endregion
    }
}
