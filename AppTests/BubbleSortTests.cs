using AppToBeTested;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void TestSort_UnsortedArray()
        {
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expectedSortedArray = { 11, 12, 22, 25, 34, 64, 90 };
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(unsortedArray);
            CollectionAssert.AreEqual(expectedSortedArray, unsortedArray);
        }
        [TestMethod]
        public void TestSort_SortedArray()
        {
            int[] sortedArray = { 10, 20, 30, 40, 50 };
            int[] expectedSortedArray = { 10, 20, 30, 40, 50 };
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(sortedArray);
            CollectionAssert.AreEqual(expectedSortedArray, sortedArray);
        }
        [TestMethod]
        public void TestSort_EmptyArray()
        {
            int[] emptyArray = new int[0];
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(emptyArray);
            CollectionAssert.AreEqual(new int[0], emptyArray);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSort_NullArray()
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(null);
            // Assert: Expecting ArgumentNullException
        }
    }
}
