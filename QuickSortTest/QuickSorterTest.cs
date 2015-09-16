using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace QuickSortTest
{
    [TestClass]
    public class QuickSorterTest
    {
        private int[] bigActualSorted_EvenNumberOfElements = new int[1000];
        private int[] bigActualDescSorted_EvenNumberOfElements = new int[1000];
        private int[] bigActualEqualsNumbers_EvenNumberOfElements = new int[1000];
        private int[] bigExpected_EvenNumberOfElements = new int[1000];
        private int[] bigExpectedEqualsNumbers_EvenNumberOfElements = new int[1000];

        private int[] bigActualSorted_OddNumberOfElements = new int[999];
        private int[] bigActualDescSorted_OddNumberOfElements = new int[999];
        private int[] bigActualEqualsNumbers_OddNumberOfElements = new int[999];
        private int[] bigExpected_OddNumberOfElements = new int[999];
        private int[] bigExpectedEqualsNumbers_OddNumberOfElements = new int[999];

        private void Initialize_EvenNumberOfElements()
        {
            for (int i = 0; i < 1000; ++i)
            {
                bigActualSorted_EvenNumberOfElements[i] = i;
                bigActualDescSorted_EvenNumberOfElements[i] = 999 - i;
                bigExpected_EvenNumberOfElements[i] = i;
                bigActualEqualsNumbers_EvenNumberOfElements[i] = 8;
                bigExpectedEqualsNumbers_EvenNumberOfElements[i] = 8;
            }
        }

        private void Initialize_OddNumberOfElements()
        {
            for (int i = 0; i < 999; ++i)
            {
                bigActualSorted_OddNumberOfElements[i] = i;
                bigActualDescSorted_OddNumberOfElements[i] = 998 - i;
                bigExpected_OddNumberOfElements[i] = i;
                bigActualEqualsNumbers_OddNumberOfElements[i] = 8;
                bigExpectedEqualsNumbers_OddNumberOfElements[i] = 8;
            }
        }

        [TestMethod]
        public void Sort_WithEmptyArray()
        {
            int[] actual = new int[0] { };
            QuickSorter.Sort(ref actual, 0, 0);
            int[] expected = new int[0] { };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithOneElementArray()
        {
            int[] actual = new int[1] { 7 };
            QuickSorter.Sort(ref actual, 0, 0);
            int[] expected = new int[1] { 7 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithEvenQuantity_SortedArray()
        {
            int[] actual = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            QuickSorter.Sort(ref actual, 0, 9);
            int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithEvenQuantity_DescSortedArray()
        {
            int[] actual = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            QuickSorter.Sort(ref actual, 0, 9);
            int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithEvenQuantity_ArrayOfEqualNumbers()
        {
            int[] actual = new int[10] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
            QuickSorter.Sort(ref actual, 0, 9);
            int[] expected = new int[10] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithOddQuantity_SortedArray()
        {
            int[] actual = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            QuickSorter.Sort(ref actual, 0, 10);
            int[] expected = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithOddQuantity_DescSortedArray()
        {
            int[] actual = new int[11] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            QuickSorter.Sort(ref actual, 0, 10);
            int[] expected = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_WithOddQuantity_ArrayOfEqualNumbers()
        {
            int[] actual = new int[11] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
            QuickSorter.Sort(ref actual, 0, 10);
            int[] expected = new int[11] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_With_EvenQuantity_BigSortedArray()
        {
            QuickSorter.Sort(ref bigActualSorted_EvenNumberOfElements, 0, bigActualSorted_EvenNumberOfElements.Length - 1);

            CollectionAssert.AreEqual(bigExpected_EvenNumberOfElements, bigActualSorted_EvenNumberOfElements);
        }

        [TestMethod]
        public void Sort_With_EvenQuantity_BigDescSortedArray()
        {
            QuickSorter.Sort(ref bigActualDescSorted_EvenNumberOfElements, 0, bigActualDescSorted_EvenNumberOfElements.Length - 1);

            CollectionAssert.AreEqual(bigExpected_EvenNumberOfElements, bigActualDescSorted_EvenNumberOfElements);
        }

        [TestMethod]
        public void Sort_With_EvenQuantity_BigArrayOfEqualNumbers()
        {
            QuickSorter.Sort(ref bigActualEqualsNumbers_EvenNumberOfElements, 0, bigActualEqualsNumbers_EvenNumberOfElements.Length - 1);

            CollectionAssert.AreEqual(bigExpectedEqualsNumbers_EvenNumberOfElements, bigActualEqualsNumbers_EvenNumberOfElements);
        }

        [TestMethod]
        public void Sort_With_OddQuantity_BigSortedArray()
        {
            QuickSorter.Sort(ref bigActualSorted_OddNumberOfElements, 0, bigActualSorted_OddNumberOfElements.Length - 1);

            CollectionAssert.AreEqual(bigExpected_OddNumberOfElements, bigActualSorted_OddNumberOfElements);
        }

        [TestMethod]
        public void Sort_With_OddQuantity_BigDescSortedArray()
        {
            QuickSorter.Sort(ref bigActualDescSorted_OddNumberOfElements, 0, bigActualDescSorted_OddNumberOfElements.Length - 1);

            CollectionAssert.AreEqual(bigExpected_OddNumberOfElements, bigActualDescSorted_OddNumberOfElements);
        }

        [TestMethod]
        public void Sort_With_OddQuantity_BigArrayOfEqualNumbers()
        {
            QuickSorter.Sort(ref bigActualEqualsNumbers_OddNumberOfElements, 0, bigActualEqualsNumbers_OddNumberOfElements.Length - 1);

            CollectionAssert.AreEqual(bigExpectedEqualsNumbers_OddNumberOfElements, bigActualEqualsNumbers_OddNumberOfElements);
        }
    }
}
