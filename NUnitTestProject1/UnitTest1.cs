using NUnit.Framework;
using HashTableAndBinaryTree;

namespace NUnitTestProject1
{
    public class Tests
    {
        /// <summary>
        /// TC-1 Test to check frequency of words in a sentence
        /// </summary>
        [Test]
        public void GivenASentence_WhenWordsAreAddedToList_ShouldReturnWordFrequency()
        {
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

            int frequency = myHashMap.get("to");
            Assert.AreEqual(2, frequency);
        }

        /// <summary>
        /// TC-2 Test to check frequency of words in a paragraph
        /// </summary>
        [Test]
        public void GivenParagraph_WhenWordsAreAddedToList_ShouldReturnWordFrequency()
        {
            string sentence = "Paranoids are not paranoid because they are paranoid but " +
                                "because they keep putting themselves deliberately into " +
                                "paranoid avoidable situations";
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

            int frequency = myLinkedHashMap.get("they");
            Assert.AreEqual(3, frequency);
        }

        /// <summary>
        /// TC-3 Test to check frequency of words in a paragraph
        /// </summary>
        [Test]
        public void GivenParagraph_WhenWordIsRemoved_ShouldReturnZero()
        {
            string sentence = "Paranoids are not paranoid because they are paranoid but " +
                                "because they keep putting themselves deliberately into " +
                                "paranoid avoidable situations";
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
            Assert.AreEqual(0, frequency);

        }
}