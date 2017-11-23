namespace BigO_Notation.Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Hashing : BaseSort
    {
        private string[] lastNames;

        public Hashing()
        {
            DisplayMenu();

            while (true)
            {    
                int selection;
                int.TryParse(Console.ReadLine(), out selection);
                int collisionCounter = 0;
                HashSet<int> hashSet = new HashSet<int>();

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("\nHash1");
                        foreach (string name in lastNames)
                        {
                            int hashValue = Hash1(name, 2 * lastNames.Length);

                            if (!hashSet.Add(hashValue))
                            {
                                collisionCounter++;
                            }
                            Console.WriteLine(string.Format("\n {0, -15}, {1}", name, hashValue.ToString()));
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nHash2");
                        foreach (string name in lastNames)
                        {
                            int hashValue = Hash2(name, 2 * lastNames.Length);

                            if (!hashSet.Add(hashValue))
                            {
                                collisionCounter++;
                            }
                            Console.WriteLine(string.Format("\n {0, -15}, {1}", name, hashValue.ToString()));
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nMultiplication_Hash");
                        foreach (string name in lastNames)
                        {
                            Random rand = new Random();
                            int hashValue = Multiplication_Hash(rand.Next(0, 1000) * name.Length);

                            if (!hashSet.Add(hashValue))
                            {
                                collisionCounter++;
                            }

                            Console.WriteLine(string.Format("\n {0, -15}, {1}", name, hashValue.ToString()));
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nelfHash");
                        foreach (string name in lastNames)
                        {
                            long hashValue = elfHash(name);
                            int index = mod(hashValue, 2*lastNames.Length);

                            if (!hashSet.Add(index))
                            {
                                collisionCounter++;
                            }

                            Console.WriteLine(string.Format("\n {0, -15}, {1}, {2}", name, hashValue.ToString(), index));
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nsumOfShiftedChars");
                        foreach (string name in lastNames)
                        {
                            int hashValue = sumOfShiftedChars(name);
                            int index = mod(hashValue, 2*lastNames.Length);
                            if (!hashSet.Add(index))
                            {
                                collisionCounter++;
                            }
                            Console.WriteLine(string.Format("\n {0, -15}, {1}, {2}", name, hashValue.ToString(), index));
                        }
                        break;
                    case 9:
                        Console.WriteLine("\nExit App");
                        break;
                    default:
                        Console.WriteLine("\n");
                        break;
                }

                //pause
                Console.WriteLine(string.Format("\n\n Number of collisions: {0}", collisionCounter.ToString()));
                Console.WriteLine("\n\n Hit enter to continue");
                Console.ReadLine();
                Console.Clear();
            }      
        }

        //using division method
        public int Hash1(string key, int array_size)
        {
            //the simplest hashing function uses a simple formula. It takes the 
            //key; it divides it
            //by the array_size, and the remainder is the hash value (the index 
            //of item with
            //the given key
            int sum = 0;

            foreach (char k in key)
            {
                sum += (int)k;
            }

            int index = sum % array_size;

            return index;
        }

        //using Knuth variant on division h(k)=k(k+3)
        public int Hash2(string key, int array_size)
        {
            int sum = 0;

            foreach (char k in key)
            {
                sum += (int)k;
            }

            int index = sum * (sum + 3);

            return index;
        }

        public int Multiplication_Hash(int k)
        {
            //the value of A is set the suggest value likely to work  0<A<1
            // let w=32 (32 bit key)
            // let s,  0<s<2^w
            // A = s/2^w   (so A is less than 1
            double A = (Math.Sqrt(5) - 1) / 2;//works for most cases
                                              //m must be a power of 2 (for some power)
                                              //in this case power p=14
            int m = (int)Math.Pow(2, 14);
            int index = (int)Math.Floor(m * ((k * A) % 1));
            return index;
        }

        public long elfHash(String toHash)
        {
            long hashValue = 0;

            for (int Pos = 0; Pos < toHash.Length; Pos++)
            {
                // use all elements
                hashValue = (hashValue << 4) + toHash[Pos]; // shift/mix
                long hiBits = hashValue & 0xF0000000; // get high nybble

                if (hiBits != 0)
                {
                    hashValue ^= hiBits >> 24; // xor high nybble with second nybble
                    hashValue &= ~hiBits; // clear high nibble
                }
            }

            return hashValue;
        }

        public int sumOfShiftedChars(String toHash)
        {
            int hashValue = 0;

            for (int Pos = 0; Pos < toHash.Length; Pos++)
            {
                hashValue = (hashValue << 4) + toHash[Pos];
            }

            return hashValue;
        }

        #region Private Methods

        /// <summary>
        /// Gets the index of the table size
        /// </summary>
        /// <param name="hashValue"></param>
        /// <param name="tableSize"></param>
        /// <returns></returns>
        private int mod(long hashValue, int tableSize)
        {
            return (int)(hashValue % tableSize);
        }

        /// <summary>
        /// To reduce the number of collisions the size of the array should be prime number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string[] GetRandomSetOfNames(int number)
        {
            Random rand = new Random();
            string[] names = new string[number];

            for(int i = 0; i< number;i++)
            {
                names[i] = this.lastNames[rand.Next(lastNames.Length)];
            }

            return names;
        }

        /// <summary>
        /// Display console menu
        /// </summary>
        private void DisplayMenu()
        {
            //Read the file
            this.lastNames = File.ReadAllLines("c:/BigO_Notation/BigO_Notation/bin/Debug/lastnames.txt");
            this.lastNames = GetRandomSetOfNames(25);

            Console.WriteLine("Enter selection: ");
            Console.WriteLine("\n t1. Hash1");
            Console.WriteLine("\n t2. Hash2");
            Console.WriteLine("\n t3. Multiplication_Hash");
            Console.WriteLine("\n t4. elfHash");
            Console.WriteLine("\n t5. sumOfShiftedChars");
            Console.WriteLine("\n t9. Exit App");
            Console.WriteLine("\n ----------------------------------");
        }
        #endregion
    }
}
