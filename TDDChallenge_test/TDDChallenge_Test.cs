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
            Assert.IsTrue(result[0] <= result[1]);
            Assert.IsTrue(result[6] <= result[7]);
            Assert.IsTrue(result[0] <= result[7]);
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

    }
}
