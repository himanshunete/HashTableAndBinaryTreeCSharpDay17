using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBinaryTree
{
    public class MyBinaryTree<K> where K:IComparable
    {
        public MyBinaryNode<K> root ;
	
	public void add(K key) {
		this.root = this.addRecursively(root, key) ;
	}
	
	public MyBinaryNode<K> addRecursively( MyBinaryNode<K> current, K key ) {
		if (current == null) {
			return new MyBinaryNode<K>(key) ;
		}
		int compareResult = key.CompareTo(current.key) ;
        if (compareResult == 0 ) return current ;
		if (compareResult < 0) {
			current.left = addRecursively(current.left, key);
		} else {
			current.right = addRecursively(current.right, key); 
		}
		return current ;
		
	}
	
	public int getSize() {
		return this.getSizeRecursive(root) ;
	}
	
	public int getSizeRecursive(MyBinaryNode<K> current) {
		return current == null ? 0 : 1 + this.getSizeRecursive(current.left)
		                               + this.getSizeRecursive(current.right) ;		
	}
    }
}
