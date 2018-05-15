using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal class AnonymousTypes
    {
        public AnonymousTypes()
        {
            var myAnonymousType = new
            {
                firstProperty = "first",
                secondProperty = 2,
                thirdProprty = true,
                anotherAnonymousType = new
                {
                    nestedProperty = "nested"
                }
            };

            Console.WriteLine(myAnonymousType.GetType().ToString());

            PassingAnonymousType(myAnonymousType);
        }

        internal static void PassingAnonymousType(dynamic param)
        {
            Console.WriteLine(param.firstProperty);
        }
    }
}
