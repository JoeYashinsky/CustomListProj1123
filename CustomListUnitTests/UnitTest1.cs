using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListTest
    {
        //ADD test
        [TestMethod]
        public void Add_PositiveNumber_CountOfOne()
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

        [TestMethod]
        public void Add_String_CountOfOne()
        {
            //Arrange
            CustomList<string> singleString = new CustomList<string>();
            string firstString = "Welcome";
            int expected = 1;
            int actual;

            //Actual
            singleString.Add(firstString);
            actual = singleString.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ListOfStrings_CountOfThree()
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

        [TestMethod]
        public void Add_Negative_Numbers_CountOfFive()
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

        [TestMethod]
        public void Add_SevenPositiveNumbers_CapacityTwelve()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 3;
            int thirdNumber = 5;
            int fourthNumber = 7;
            int fifthNumber = 9;
            int sixthNumber = 11;
            int seventhNumber = 13;

            int expected = 12;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            numberList.Add(fourthNumber);
            numberList.Add(fifthNumber);
            numberList.Add(sixthNumber);
            numberList.Add(seventhNumber);
            
            actual = numberList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //REMOVE test
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
        public void Remove_TwoNegativeNumbers_CountThree()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = -1;
            int secondNumber = -3;
            int thirdNumber = -5;
            int fourthNumber = -7;
            int fifthNumber = -9;
            int expected = 3;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            numberList.Add(fourthNumber);
            numberList.Add(fifthNumber);
            numberList.Remove(secondNumber);
            numberList.Remove(fourthNumber);
            actual = numberList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_PositiveAndNegativeIntegers_CapacitySix()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 2;
            int secondNumber = -3;
            int thirdNumber = 4;
            int fourthNumber = -5;
            int fifthNumber = 6;
            int sixthNumber = -7;
            int seventhNumber = 8;
            int eighthNumber = -9;
            int ninthNumber = 10;
            int expected = 6;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            numberList.Add(fourthNumber);
            numberList.Add(fifthNumber);
            numberList.Add(sixthNumber);
            numberList.Add(seventhNumber);
            numberList.Add(eighthNumber);
            numberList.Add(ninthNumber);
            numberList.Remove(secondNumber);
            numberList.Remove(fourthNumber);
            numberList.Remove(sixthNumber);
            numberList.Remove(eighthNumber);
            actual = numberList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ListOfStrings_CountTwo()
        {
            //Arrange
            CustomList<string> listOfStrings = new CustomList<string>();
            string firstString = "Go";
            string secondString = "Cubs";
            string thirdString = "Go";
            string fourthString = "!";
            int expected = 2;
            int actual;

            //Act
            listOfStrings.Add(firstString);
            listOfStrings.Add(secondString);
            listOfStrings.Add(thirdString);
            listOfStrings.Add(fourthString);
            listOfStrings.Remove(thirdString);
            listOfStrings.Remove(fourthString);
            actual = listOfStrings.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ListOfBools_CountThree()
        {
            //Arrange
            CustomList<bool> bools = new CustomList<bool>();
            bool bool1 = true;
            bool bool2 = false;
            bool bool3 = true;
            bool bool4 = false;
            bool bool5 = true;
            int expected = 3;
            int actual;

            //Act
            bools.Add(bool1);
            bools.Add(bool2);
            bools.Add(bool3);
            bools.Add(bool4);
            bools.Add(bool5);
            bools.Remove(bool2);
            bools.Remove(bool4);
            actual = bools.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //OverrideToString test
        [TestMethod]

        public void ToString_ConvertContentsOfCustomListToString_SingleString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 7;
            int fourthNumber = 8;
            string expected = "1278";
            string actual;

            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            list.Add(thirdNumber);
            list.Add(fourthNumber);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //INDEXER test
        [TestMethod]
        public void Add_OneInteger_ZeroIndexValue25()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 25;
            int expected = 25;
            int actual;

            //Act
            numberList.Add(firstNumber);
            actual = numberList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Add_FourNumbers_AtTwoIndexValueSix()
        {
            //Arrange
            CustomList<int> numberList = new CustomList<int>();
            int firstNumber = 4;
            int secondNumber = 5;
            int thirdNumber = 6;
            int fourthNumber = 7;

            int expected = 6;
            int actual;

            //Act
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            numberList.Add(fourthNumber);
            actual = numberList[2];

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

        ////OverloadPlusOperator test
        //[TestMethod]
        //public void AddOperator_TwoLists_FinalListHasCountSix()
        //{
        //    //Arrange
        //    CustomList<int> listOne = new CustomList<int>() { };
        //    CustomList<int> listTwo = new CustomList<int>() { };
        //    CustomList<int> listResult = new CustomList<int>() { };
        //    int firstNumber = 1;
        //    int secondNumber = 3;
        //    int thirdNumber = 5;
        //    int fourthNumber = 2;
        //    int fifthNumber = 4;
        //    int sixthNumber = 6;
        //    int expected = 6;
        //    int actual;

        //    //Act
        //    listOne.Add(firstNumber);
        //    listOne.Add(secondNumber);
        //    listOne.Add(thirdNumber);
        //    listTwo.Add(fourthNumber);
        //    listTwo.Add(fifthNumber);
        //    listTwo.Add(sixthNumber);

        //    listResult = listOne + listTwo;
        //    actual = listResult.Count;          //Should read:  1, 3, 5, 2, 4, 6

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //OverloadMinusOperator test
        [TestMethod]
        public void MinusOperator_TwoLists_FinalList()
        {

        }

        //ZIP Test   
        //[TestMethod]
        //public void Zip_TwoCustomLists_ZippedTogetherInFormOfZipper()
        //{
        //    //Arrange
        //    CustomList<int> listOne = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> zipperedList = new CustomList<int>();
        //    int firstNumber = 1;
        //    int secondNumber = 3;
        //    int thirdNumber = 5;
        //    int fourthNumber = 2;
        //    int fifthNumber = 4;
        //    int sixthNumber = 6;
        //    string expected = "1, 2, 3, 4, 5, 6";
        //    string actual;

        //    //Act
        //    listOne.Add(firstNumber);
        //    listOne.Add(secondNumber);
        //    listOne.Add(thirdNumber);
        //    listOne.Add(fourthNumber);
        //    listOne.Add(fifthNumber);
        //    listOne.Add(sixthNumber);
        //    zipperedList = zipperedList.Zip(listOne, listTwo);
        //    actual = zipperedList.ToString();

        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //}
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
