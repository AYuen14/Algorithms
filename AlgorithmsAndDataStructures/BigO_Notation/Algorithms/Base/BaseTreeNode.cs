using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms.Base
{
    internal class BaseTreeNode
    {
        internal DictionaryEntry _entry;
        internal BaseTreeNode _left;
        internal BaseTreeNode _right;
        internal int _height;

        public BaseTreeNode(int key, object value)
        {
            if(key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if(value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            this._entry = new DictionaryEntry(key, value);
            this._left = this._right = null;
            this._height = 0;
        }
    }
}
