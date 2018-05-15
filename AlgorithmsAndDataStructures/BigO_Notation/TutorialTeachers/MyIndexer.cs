using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    class MyIndexer
    {
        //Internal data storage
        private string[] strArray = new string[10];

        public MyIndexer()
        {
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArray.Length)
                {
                    throw new ArgumentOutOfRangeException("Can not store more than 10 objects");
                }

                return strArray[index];
            }
            set
            {
                if (index < 0 && index >= strArray.Length)
                {
                    throw new ArgumentOutOfRangeException("Can not store more than 10 objects");
                }

                strArray[index] = value;
            }
        }

        public string this[string index]
        {
            get
            {
                foreach(string str in strArray)
                {
                    if(str.ToLower() == index.ToLower())
                    {
                        return str;
                    }
                }

                return null;
            }
        }
    }
}
