using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDChallenge;

namespace TDDChallenge_test
{
    [TestClass]
    public class Challenge_Test
    {
    #region NullTest
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void SortArray_isNotNull()
        {
            //Given
            Challenge challenge = new Challenge();
            int[] numbers = null;

            //when
            int[] result = challenge.SortArray(numbers);

            //then
            
        }
        #endregion

    #region SortedTest
        [TestMethod]
        public void SortArray_isSorted()
        {
            //Given
            Challenge challenge = new Challenge();
            int[] numbers = { 8, -5, 0, 9, 10, -10, 1, 8 };
            int[] sortedNumbers = { -10, -5, 0, 1, 8, 8, 9, 10 };

            //when
            int[] result = challenge.SortArray(numbers);


            //then
            CollectionAssert.AreEqual(numbers, sortedNumbers);
        }
        #endregion

    #region SameLenghtTest
        [TestMethod]
        public void SortArray_hasSameLenght()
        {
            //Given
            Challenge challenge = new Challenge();
            int[] numbers = { 8, -5, 0, 9, 10, -10, 1, 8 };
            int[] sortedNumbers = { -10, -5, 0, 1, 8, 8, 9, 10 };

            //when
            int[] result = challenge.SortArray(numbers);

            //then
            Assert.IsTrue(result.Length == sortedNumbers.Length);
        }
        #endregion

        #region EmptyArray
        [TestMethod]
        public void SortArray_EmptyArray()
        {
            //Given
            Challenge challenge = new Challenge();
            int[] numbers = { };
            int[] sortedNumbers = { };

            //when
            int[] result = challenge.SortArray(numbers);

            //then
            CollectionAssert.AreEqual(numbers, sortedNumbers);
        }
        #endregion

    }
}
