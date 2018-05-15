using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers.Collections
{
    internal class MyArrayList
    {
        public MyArrayList()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(3);
            arryList1.Add(2);
            arryList1.Add(4);
            arryList1.Add(1);

            ArrayList arryList2 = new ArrayList();
            arryList2.Add(6);
            arryList2.Add(0);

            arryList1.AddRange(arryList2);

            int firstElement = (int)arryList1[0];

            arryList1.Insert(0, 9);

            arryList1.RemoveAt(1);

            arryList1.Sort();

            arryList1.Reverse();
        }
    }
}
