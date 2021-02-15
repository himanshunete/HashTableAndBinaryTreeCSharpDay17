using System;

namespace HashTableAndBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            //HashTable
            Console.WriteLine("Hello World!");
            string sentence = "Paranoids are not paranoid they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            MyLinkedHashMap myLinkedHashMap = new MyLinkedHashMap();
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myLinkedHashMap.get(word);
                if (value == 0) value = 1;
                else value = value + 1;
                myLinkedHashMap.add(word, value);
            }
            myLinkedHashMap.remove("avoidable");
            int frequency = myLinkedHashMap.get("avoidable");

            Console.WriteLine(frequency);


            //Binary Tree
            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>();
            myBinaryTree.add(56);
            myBinaryTree.add(30);
            myBinaryTree.add(70);
            myBinaryTree.add(22);
            myBinaryTree.add(40);
            myBinaryTree.add(11);
            myBinaryTree.add(3);
            myBinaryTree.add(16);
            myBinaryTree.add(60);
            myBinaryTree.add(95);
            myBinaryTree.add(65);
            myBinaryTree.add(63);
            myBinaryTree.add(67);
            myBinaryTree.search(63);
            int size = myBinaryTree.getSize();
            Console.WriteLine(size);
        }
    }
}
