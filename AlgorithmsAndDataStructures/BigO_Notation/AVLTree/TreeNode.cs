namespace BigO_Notation.AVLTree
{
    using System.Collections;

    internal class TreeNode
    {
        internal DictionaryEntry entry;
        internal TreeNode leftNode;
        internal TreeNode rightNode;
        internal int height;

        public TreeNode(int key, object value)
        {
            this.entry = new DictionaryEntry(key, value);
            this.leftNode = null;
            this.rightNode = null;
            this.height = 0;
        }
    }
}
