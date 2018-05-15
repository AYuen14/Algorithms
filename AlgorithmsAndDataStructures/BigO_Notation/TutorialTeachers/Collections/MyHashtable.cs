using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BigO_Notation.TutorialTeachers.Collections
{
    class MyHashtable
    {

        public class baseclass
        {
            public virtual void test()
            {

            }
        }

        public class derivedclass: baseclass
        {
            public override void test()
            {
                base.test();
            }
        }
        public MyHashtable()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");

            Hashtable ht = new Hashtable(dict);

            if (!ht.Contains(1))
            {
                ht.Add(1, "One");
            }
            
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);

            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(string.Format("Key: {0} Value: {1}", de.Key, de.Value));
            }

            ht.Remove(2);
            ht.Clear();
        }
    }
}
