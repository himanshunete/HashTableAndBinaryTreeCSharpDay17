using System;

namespace HashTableAndBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string sentence = "To be or not to be";
            MyHashMap myHashMap = new MyHashMap();
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myHashMap.get(word);
                if (value == 0) value = 1;
                else value = value + 1;
                myHashMap.add(word, value);
            }

            int frequency = myHashMap.get("or");
            Console.WriteLine(frequency);
            Console.WriteLine(myHashMap);
        }
    }
}
