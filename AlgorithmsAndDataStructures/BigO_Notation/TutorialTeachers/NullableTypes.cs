using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal class NullableTypes
    {
        public NullableTypes()
        {
            Nullable<int> i = null;

            if(i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }

            Console.WriteLine(i.GetValueOrDefault());
        }
    }
}
