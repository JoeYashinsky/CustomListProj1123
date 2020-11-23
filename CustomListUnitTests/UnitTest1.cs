using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListUnitTest
    {
        [TestMethod]
        public void Add_PositiveNumber_CountOf1()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 3;
            int expected = 1;
            int actual;

            //Act
            numberList.Add(firstNumber);
            actual = numberList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_ListOfStrings_CountOf3()
        {
            //Arrange
            CustomList<string> listOfStrings = new CustomList<string>();
            string firstString = "Tinker";
            string secondString = "Evers";
            string thirdString = "Chance";

            int expected = 3;
            int actual;

            //Act
            listOfStrings.Add(firstString);
            listOfStrings.Add(secondString);
            listOfStrings.Add(thirdString);
            actual = listOfStrings.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_Negative_Numbers_CountOf5()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = -2;
            int secondNumber = -4;
            int thirdNumber = -6;
            int fourthNumber = -8;
            int fifthNumber = -10;
            int expected = 5;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            numberList.Add(fourthNumber);
            numberList.Add(fifthNumber);
            
            actual = numberList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}


//public void Add_PostiveInteger_CountOfOne()
//{
//    //arrange
//    CustomList<int> myList = new CustomList<int>();
//    int value1 = 5;
//    int expected = 1;
//    int actual;
//    //act
//    myList.Add(value1);
//    actual = myList.Count;
//    //assert
//    Assert.AreEqual(expected, actual);
//}

//[TestMethod]
//public void Add_PostiveIntegers_CountOfFour()
//{
//    //arrange
//    CustomList<int> myList = new CustomList<int>();
//    int value1 = 5;
//    int value2 = 5;
//    int value3 = 5;
//    int value4 = 5;
//    int expected = 4;
//    int actual;
//    //act
//    myList.Add(value1);
//    myList.Add(value2);
//    myList.Add(value3);
//    myList.Add(value4);
//    actual = myList.Count;
//    //assert
//    Assert.AreEqual(expected, actual);
//}

//[TestMethod]
//public void Add_PostiveIntegers_CapacityOfFour()
//{
//    //arrange
//    CustomList<int> myList = new CustomList<int>();
//    int value1 = 5;
//    int value2 = 5;
//    int value3 = 5;
//    int value4 = 5;
//    int expected = 4;
//    int actual;
//    //act
//    myList.Add(value1);
//    myList.Add(value2);
//    myList.Add(value3);
//    myList.Add(value4);
//    actual = myList.Capacity;
//    //assert
//    Assert.AreEqual(expected, actual);
//}
