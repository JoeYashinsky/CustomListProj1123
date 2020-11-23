using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListRemoveTest
    {
        [TestMethod]
        public void Remove_PositiveNumber_CountOne()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;

            int expected = 1;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Remove(firstNumber);
            actual = numberList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_TwoIndex_TwoIndexValueThree()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 5;
            int thirdNumber = 2;
            int fourthNumber = 3;

            int expected = 3;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            numberList.Add(fourthNumber);
            numberList.Remove(thirdNumber);
            actual = numberList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
