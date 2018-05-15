using BigO_Notation.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using project = System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    class MyExceptionHandling
    {
        public MyExceptionHandling()
        {
            Console.Write("Please enter two numbers: ");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);

                try
                {
                    Student std = null;
                    //std.StudentName = "";
                }
                catch
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch(project.WebException ex) when(ex.Status == project.WebExceptionStatus.ProtocolError)
            {
                Console.Write("Not a valid number. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid number. Please try again.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occurred");
            }
            finally
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }

            Console.ReadKey();
        }

    }
}
