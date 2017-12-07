using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace The_BitArray_Collection
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Constructors
            //============

          //  //1. //create a BitArray from an array of boolean values
          //  bool[] barray = { true, false, false, true, true, true, false, false,true,true,false,true };
          //  BitArray ba1 = new BitArray(barray);
          //  DisplayBitArray(ba1);
          //  DisplayBitArrayMostToLeast(ba1);

          //  //2: create a BitArray from bytes
          ////  byte[] bytes = { 0xE1, 0x3D, 0x5E, 0x9A };
          //  byte[] bytes = { 1, 2, 3, 4 };
          //  BitArray ba2 = new BitArray(bytes);
          //  ///The first byte in the array represents bits 0 through 7, the second byte represents bits 8 through 15, and so on. 
          //  ///The Least Significant Bit of each byte represents the lowest index value: " bytes [0] & 1" represents bit 0, 
          //  ///" bytes [0] & 2" represents bit 1, " bytes [0] & 4" represents bit 2, and so on.
          //  DisplayBitArray(ba2);
          //  DisplayBitArrayMostToLeast(ba2);

          //  //3: Create a BitArray that holds 32 bits
          //  BitArray ba3 = new BitArray(32); //initially all the bits are set to false
          //  DisplayBitArray(ba3);
          //  DisplayBitArrayMostToLeast(ba3);

          //  //4. Create a BitArray from an array of ints
          //  BitArray ba4 = new BitArray(new int[] {1,2 });
          //  ///The number in the first values array element represents bits 0 through 31, 
          //  ///the second number in the array represents bits 32 through 63, and so on. 
          //  ///The Least Significant Bit of each integer represents the lowest index value: 
          //  ///" values [0] & 1" represents bit 0, " values [0] & 2" represents bit 1, " values [0] & 4" represents bit 2, and so on.
          //  DisplayBitArray(ba4);
          //  DisplayBitArrayMostToLeast(ba4);

          //  //5. Create a BitArray that holds 32 bits, all set to true (1)
          //  BitArray ba5 = new BitArray(32, true);
          //  DisplayBitArray(ba5);
          //  DisplayBitArrayMostToLeast(ba5);

            //Methods
            //=======
            BitArray ba6 = new BitArray(8); //bit array holding 8 bits initially set to false
            Console.WriteLine("\n\nBit array of size 8, initially all bits are set to false");
            DisplayBitArray2(ba6);

            
            //Set the bit at index 1 to true
            Console.WriteLine("\n\nSet Bit 1 and bit count-2 to true:\n");
            ba6.Set(1, true);
            //set bit at index count-2 to true
            ba6.Set(ba6.Count - 2, true);
            DisplayBitArray2(ba6);

            //invert it
            Console.WriteLine("\n\nInvert all the bits: \n");
            ba6.Not();
            DisplayBitArray2(ba6);

            ///=========================================================================================
            //toggle all the bits
            //use the Xor method
            BitArray toggler = new BitArray(new byte[] { 255 });
            ba6.Xor(toggler);
            DisplayBitArray2(ba6);

            //toggle bit2 and bit5
            BitArray toggler2 = new BitArray(new bool[] { false, false, true, false, false, true, false, false });
            ba6.Xor(toggler2);
            DisplayBitArray2(ba6);

            //pause
            Console.ReadLine();
        }

        static void DisplayBitArray(BitArray ba)
        {
            Console.WriteLine("\n\n");
            int count = 0;
            foreach(bool b in ba)
            {
                count++;
                // Convert bool to int
                int i = b ? 1 : 0;
                Console.Write("{0} ", i);

                if (count % 8 == 0)
                    Console.Write(" ");

                   
            }
        }
        static void DisplayBitArrayMostToLeast(BitArray ba)
        {
            Console.WriteLine("\n");
            int count = 0;
            for (int i = ba.Count-1; i >= 0; i--)
            {
                bool b = ba[i];

                count++;
                // Convert bool to int
                int n = b ? 1 : 0;
                Console.Write("{0} ", n);

                if (count % 8 == 0)
                    Console.Write(" ");

            }
           
        }
        static void DisplayBitArray2(BitArray ba)
        {
            Console.WriteLine();
            for (int i = 0; i < ba.Count; i++)
            {
                bool b = ba[i];
                Console.WriteLine("[{0}] = {1}",i,b);
            }
        }
    }
}
