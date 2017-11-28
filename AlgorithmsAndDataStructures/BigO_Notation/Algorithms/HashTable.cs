namespace BigO_Notation.Algorithms
{
    using System;
    using System.Collections;

    /// <summary>
    /// A hashtable has an internal array. Every cell of the array is considered a bucket.
    /// This bucket should hold the key and the value
    /// in .net this bucket is a struct: DictionaryEntry
    /// </summary>
    public class HashTable
    {
        private DictionaryEntry[] _table;
        private int _count;

        public HashTable():this(17)
        {

        }

        public HashTable(int capacity)
        {
            this._table = new DictionaryEntry[capacity];
            this._count = 0;
        }

        public int Count { get { return _count; } }

        public void Display()
        {
            foreach(DictionaryEntry de in this._table)
            {           
                if (de.Key != null)
                {
                    Console.WriteLine(string.Format("Key: {0}, Value: {1}", de.Key, de.Value));
                }   
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (DictionaryEntry de in this._table)
            {
                if (de.Key != null)
                {
                    yield return de;
                }
            }
        }

        /// <summary>
        /// Add new element to the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(object key, object value)
        {
            int i = 0;
            int index = LinearProbe(key.ToString(), i, this._table.Length);

            while(this._table[index].Key != null)
            {
                //Increment i and allow circular table
                i = (i+1) % this._table.Length;

                //Recalculate index
                index = LinearProbe(key.ToString(), i, this._table.Length);
            }

            //the while loop exits when an empty entry is found
            this._table[index] = new DictionaryEntry(key, value);
        }

        public object Get(object key)
        {
            object returnValue = null;
            int i = 0;
            int index = LinearProbe(key.ToString(), i, this._table.Length);

            while (this._table[index].Key != null)
            {
                if(this._table[index].Key.Equals(key))
                {
                    returnValue = this._table[index].Value;
                    break;
                }

                //Increment i and allow circular table
                i = (i + 1) % this._table.Length;

                //Recalculate index
                index = LinearProbe(key.ToString(), i, this._table.Length);
            }

            return returnValue;
        }

        public bool Remove(object key)
        {
            int i = 0;
            int index = LinearProbe(key.ToString(), i, this._table.Length);

            while(!this._table[index].Key.Equals(key))
            {
                if(this._table[index].Key == null)
                {
                    return false;
                }

                //Increment i and allow circular table
                i = (i + 1) % this._table.Length;

                //Recalculate index
                index = LinearProbe(key.ToString(), i, this._table.Length);
            }

            //found at index
            //null the key to indicate the entry is reusable
            this._table[index] = new DictionaryEntry(null, null);
            this._count--;

            //rehash the entire table
            //create a temp array same size
            DictionaryEntry[] temp = new DictionaryEntry[this._table.Length];

            foreach(DictionaryEntry de in this._table)
            {
                i = 0;
                index = LinearProbe(key.ToString(), i, temp.Length);

                while (temp[index].Key != null)
                {
                    //Increment i and allow circular table
                    i = (i + 1) % temp.Length;

                    //Recalculate index
                    index = LinearProbe(key.ToString(), i, temp.Length);
                }

                //the while loop exits when an empty entry is found
                temp[index] = de;
            }

            //reset the table back to temp
            this._table = temp;
            return true;
        }

        #region Private Methods
        private int Hash(string s, int table_size)
        {
            Hashing hash = new Hashing();
            return hash.sfoldHash(s, table_size);
        }

        private int LinearProbe(string k, int i, int tableSize)
        {
            //For linear probing
            //hi(k) = (hash(k) + i) % tableSize
            return (Hash(k, tableSize) + i) % tableSize;
        }
        #endregion
    }
}
