using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBinaryTree
{
    public class MyBinaryNode<K> where K:IComparable
    {
		public K key;
		public MyBinaryNode<K> left;
		public MyBinaryNode<K> right;
		public MyBinaryNode(K key)
		{
			this.key = key;
			this.left = null;
			this.right = null;
		}
	}
}
