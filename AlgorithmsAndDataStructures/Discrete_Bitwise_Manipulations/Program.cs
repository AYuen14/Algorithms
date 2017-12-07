using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Bitwise_Manipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            do
            {
                DisplayMenu();
                Console.Write("\nEnter your selection: ");
                int.TryParse(Console.ReadLine(), out selection);
                switch (selection)
                {
                    case 1:
                        PerformAndOperation();
                        break;
                    case 2:
                        PerformORoperation();
                        break;
                    case 3:
                        PerformXORoperation();
                        break;
                    case 4:
                        PerfromNOToperation();
                        break;
                    case 5:
                        ShiftRight();
                        break;
                    case 6:
                        break;
                    case 7:                       

                        break;
                    case 8:
                        uint n,position;
                        
                        Console.Write("Enter a positive integer: ");
                        uint.TryParse(Console.ReadLine(), out n);
                        Console.WriteLine("Its binary representation is: {0}\n", ConvertIntToBinary(n).PadLeft(32, '0'));

                        Console.Write("Enter position to clear: ");
                        uint.TryParse(Console.ReadLine(), out position);

                        uint result = ClearBit(n, position);

                        break;
                    default:
                        break;
                }//end of switch

                if (selection != 9)
                {
                    //clear screen only if not exiting
                    Console.Write("\nHit any key to continue");
                    Console.ReadKey();//pause
                    Console.Clear();
                }

            } while (selection != 9);

        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n==========MENU=========================================\n");
            Console.WriteLine("\t1. AND Operation ");
            Console.WriteLine("\t2. OR Operation");
            Console.WriteLine("\t3. XOR Opertation");
            Console.WriteLine("\t4. NOT Operation");
            Console.WriteLine("\t5. SHIFT RIGHT Operation");
            Console.WriteLine("\t6. SHIFT LEFT Operation");
            Console.WriteLine("\t7. SET A PARTICULAR BIT IN A WORD");
            Console.WriteLine("\t8. CLEAR A PARTICULAR BIT IN A WORD");
            Console.WriteLine("\t9. Exit Application");
            Console.WriteLine("\n=======================================================");
        }
    //Helper method
        //method to take an int and return its binary representation in string format
        static string ConvertIntToBinary(uint n)
        {
            return Convert.ToString(n, 2); //where n is the integer value to convert and 2 is the base (for binary)
        }

        //method to convert a binary in string format to int
        static uint ConvertBinToInt(string binary)
        {
            return Convert.ToUInt32(binary, 2);//convert the string binary from base 2 to int
        }
       
        //============================CASES===========================
        //case 1:
        static void PerformAndOperation()
        {
            uint n1, n2;
            Console.Write("Enter the first integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n1);
            Console.Write("Enter the second integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n2);

            //Apply the AND operation
            uint result = n1 & n2;
            //display 
            Console.WriteLine("\n\nAND OPERATION:\n");
            Console.WriteLine("{0} AND {1} = {2}", n1, n2, result);

            Console.WriteLine("\nIn binary form:\n");
            Console.WriteLine("{0}    AND \n{1} \n= \n{2}",
                ConvertIntToBinary(n1).PadLeft(32, '0'),
                ConvertIntToBinary(n2).PadLeft(32, '0'), 
                ConvertIntToBinary(result).PadLeft(32, '0'));


        }
        //------------------------------------------------------------------------------
        //Case 2: OR operation
        static void PerformORoperation()
        {
            uint n1, n2;
            Console.Write("Enter the first integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n1);
            Console.Write("Enter the second integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n2);

            //Apply the OR operation
            uint result = n1 | n2;
            //display 
            Console.WriteLine("\n\nOR OPERATION:\n");
            Console.WriteLine("{0} OR {1} = {2}", n1, n2, result);

            Console.WriteLine("\nIn binary form:\n");
            Console.WriteLine("{0}    OR \n{1} \n= \n{2}",
                ConvertIntToBinary(n1).PadLeft(32, '0'),
                ConvertIntToBinary(n2).PadLeft(32, '0'),
                ConvertIntToBinary(result).PadLeft(32, '0'));

        }
        //------------------------------------------------------------
        //Case 3: XOR operation
        static void PerformXORoperation()
        {
            uint n1, n2;
            Console.Write("Enter the first integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n1);
            Console.Write("Enter the second integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n2);

            //Apply the XOR operation
            uint result = n1 ^ n2;
            //display 
            Console.WriteLine("\n\nXOR OPERATION:\n");
            Console.WriteLine("{0} XOR {1} = {2}", n1, n2, result);

            Console.WriteLine("\nIn binary form:\n");
            Console.WriteLine("{0}    XOR \n{1} \n= \n{2}",
                ConvertIntToBinary(n1).PadLeft(32, '0'),
                ConvertIntToBinary(n2).PadLeft(32, '0'),
                ConvertIntToBinary(result).PadLeft(32, '0'));
        }
        //Case 4: logical Not operation
        static void PerfromNOToperation()
        {
            uint n;
            Console.Write("Enter the first integer value from: {0} to {1}  : ", uint.MinValue, uint.MaxValue);
            uint.TryParse(Console.ReadLine(), out n);
            ///There is no such operation, but it could be
            ///accomplished using an XOR operation
            ///between the value n and some value, called mask
            uint mask = 0xFFFFFFFF;
            //or
            //int mask = ConvertBinToInt("11111111111111111111111111111111");
           uint result = n ^ mask;
            //display n
            //display result: n after inverting
           Console.WriteLine("{0}\n Not   \n{1} ",
              ConvertIntToBinary(n).PadLeft(32, '0'),
              ConvertIntToBinary(result).PadLeft(32, '0'));

        }
        
        //case 5: shift right
        static void ShiftRight()
        {
            uint n;
            int count;
            Console.Write("Enter  integer value to shift right  : ");
            uint.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter number of times to shift right.  count should be in the range: 1 - 32  : ");
            int.TryParse(Console.ReadLine(), out count);

            Console.WriteLine("\n\nBefore right shifting:  \n");
            Console.WriteLine(ConvertIntToBinary(n).PadLeft(32,'0'));
            uint result = n >> count;
            Console.WriteLine("\nAfter right shifting: \n");
            Console.WriteLine(ConvertIntToBinary(result).PadLeft(32,'0'));

        }
        //case 8:Clear a bit. Let position be zero-based
        static uint ClearBit(uint n, uint position)
        {
            /// to clear a specific bit in a binary number n, you must
            /// force it to be zero. That is accomplished by ANDing it
            /// with a bit=0. Since you don't want the rest of the bits
            /// in n to change, you must AND them with 1's
            /// 
            ///Basically you want to AND the value n with a mask value
            ///where all the bits are 1 except for the designated bit
            ///intended to cause a reset
            ///
            ///Example: Given a binary number 11001010
            ///recall the right most bit is bit0 (LSB)
            ///Let's say you want to clear bit3 (set it to 0) while
            ///leaving the rest of the bits unchanged. then you need
            ///to come up with a mask value = 11110111
            ///Then when you AND n with mask, the result is n with just
            ///bit3 cleared.
            ///
            ///The question is how to generate a mask, once you know
            ///what bit to clear
            ///The weight value at bit3 is 8 (2 to the 3)
            ///The Max value the mask can have is when all the bits are 1
            ///Take the Max value and subtract the effect of the 3rd bit
            ///
            uint bitweight = (uint) Math.Pow(2, position); //all the bits are zero except bit at the specified position
            //inverse the mask, so that all the bits are 1 except the bit at the position
            uint mask = 0xFFFFFFFF - bitweight;//the mask has all the bits on except bit at position

            uint result = n & mask;

            Console.WriteLine("n: \n\t {0} \nmask: \n\t {1} \nresult: \n\t {2}",
                ConvertIntToBinary(n).PadLeft(32, '0'), ConvertIntToBinary(mask).PadLeft(32, '0'), ConvertIntToBinary(result).PadLeft(32, '0'));

            return result;

        }
    }
}
