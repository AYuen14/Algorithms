using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal partial class MyPartialClass
    {
        partial void PartialMethod(int value);

        public MyPartialClass()
        {

        }

        public void Method1(int value)
        {
            Console.WriteLine(value);
        }
    }

    internal partial class MyPartialClass
    {
        partial void PartialMethod(int value)
        {
            Console.WriteLine(value);
        }

        public void Method2(int value)
        {
            Console.WriteLine(value);
        }
    }
}
