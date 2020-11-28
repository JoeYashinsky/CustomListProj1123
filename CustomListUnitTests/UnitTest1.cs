using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListTest
    {
        //As a developer, I want the ability to add an object to an instance of my custom-built class
        // by imitating the C# Add() method.
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


        //As a developer, I want the ability to remove an object to an instance of my custom-built class
        // by imitating the C# Remove() method.
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


        //As a developer, I want to create a C# indexer so that I can make the objects in my list accessible via index.
        //I want to properly ensure that a user cannot access an out-of-bounds index.
        [TestMethod]
        public void Index_OneInteger_ZeroIndexValue25()
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
        public void Index_FourNumbers_AtTwoIndexValueSix()
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
        public void Index_TwoIndex_TwoIndexValueThree()
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

        [TestMethod]
        public void Index_ProperlyEnsureUserCannotAccessOutBoundsIndex_ExceptionThrown()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstNumber = 5;
            int secondNumber = 15;
            int thirdNumber = 25;

            int expected = 0;
            int actual;

            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            list.Add(thirdNumber);
            actual = list[3];  //there is no value at the 3 index. Only at [0] [1] [2].

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //As a developer, I want to be able to override the ToString method that converts the 
        // contents of the custom list to a string.
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
        
        [TestMethod]
        public void ToString_ListOfBooleans_AlternatingTrueAndFalse()
        {
            //Arrange
            CustomList<bool> listOfBooleans = new CustomList<bool>();
            bool firstBool = true;
            bool secondBool = false;
            bool thirdBool = true;
            bool fourthBool = false;
            bool fifthBool = true;
            string expected = "truefalsetruefalsetrue";
            string actual;

            //Act
            listOfBooleans.Add(firstBool);
            listOfBooleans.Add(secondBool);
            listOfBooleans.Add(thirdBool);
            listOfBooleans.Add(fourthBool);
            listOfBooleans.Add(fifthBool);
            actual = listOfBooleans.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_CombiningFourStrings_ExpectOneContinuousString()
        {
            //Arrange
            CustomList<string> singleString = new CustomList<string>();
            string firstString = "Happy ";
            string secondString = "Gilmore ";
            string thirdString = "Billy ";
            string fourthString = "Madison";
            string expected = "Happy Gilmore Billy Madison";
            string actual;

            //Act
            singleString.Add(firstString);
            singleString.Add(secondString);
            singleString.Add(thirdString);
            singleString.Add(fourthString);
            actual = singleString.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //As a developer, I want to be able to overload the + operator so that I can 
        // add two instances of the custom list together.
        [TestMethod]
        public void AddOperator_TwoLists_FinalResult135246()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { };
            CustomList<int> listTwo = new CustomList<int>() { };
            CustomList<int> listResult;
            int firstNumber = 1;
            int secondNumber = 3;
            int thirdNumber = 5;
            int fourthNumber = 2;
            int fifthNumber = 4;
            int sixthNumber = 6;
            string expected = "135246";
            string actual;

            //Act
            listOne.Add(firstNumber);
            listOne.Add(secondNumber);
            listOne.Add(thirdNumber);
            listTwo.Add(fourthNumber);
            listTwo.Add(fifthNumber);
            listTwo.Add(sixthNumber);

            listResult = listOne + listTwo;
            actual = listResult.ToString();          //Should read: 135246

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOperator_OnlyZerosAndOnes_FinalResult0011()
        {
            //Arrange
            CustomList<int> zeroList = new CustomList<int>();
            CustomList<int> oneList = new CustomList<int>();
            CustomList<int> listResult;
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 1;
            int fourthNumber = 1;
            string expected = "0011";
            string actual;

            //Act
            zeroList.Add(firstNumber);
            zeroList.Add(secondNumber);
            oneList.Add(thirdNumber);
            oneList.Add(fourthNumber);

            listResult = zeroList + oneList;
            actual = listResult.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOperator_OddsAndEvens_FinalResult24683579()
        {
            CustomList<int> evenList = new CustomList<int>();
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> listResult;
            int firstNumber = 2;
            int secondNumber = 4;
            int thirdNumber = 6;
            int fourthNumber = 8;
            int fifthNumber = 3;
            int sixththNumber = 5;
            int seventhNumber = 7;
            int eighthNumber = 9;
            string expected = "24683579";
            string actual;

            //Act
            evenList.Add(firstNumber);
            evenList.Add(secondNumber);
            evenList.Add(thirdNumber);
            evenList.Add(fourthNumber);
            oddList.Add(fifthNumber);
            oddList.Add(sixththNumber);
            oddList.Add(secondNumber);
            oddList.Add(eighthNumber);

            listResult = oddList + evenList;
            actual = listResult.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        //As a developer, I want to be able to overload the - operator so that I can
        // subtract one instance of a custom list class from another.
        [TestMethod]
        public void MinusOperator_TwoLists_FinalResult4Only()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listResult;
            int firstNumber = 3;
            int secondNumber = 4;
            int thirdNumber = 3;
            string expected = "4";
            string actual;

            //Act
            listOne.Add(firstNumber);
            listOne.Add(secondNumber);
            listTwo.Add(thirdNumber);

            listResult = listOne - listTwo;
            actual = list.Result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);


        }

        //ZIP Test
        [TestMethod]
        public void Zip_TwoCustomLists_ZippedTogetherInFormOfZipper()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> zipperedList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 3;
            int thirdNumber = 5;
            int fourthNumber = 2;
            int fifthNumber = 4;
            int sixthNumber = 6;
            string expected = "123456";
            string actual;

            //Act
            listOne.Add(firstNumber);
            listOne.Add(secondNumber);
            listOne.Add(thirdNumber);
            listOne.Add(fourthNumber);
            listOne.Add(fifthNumber);
            listOne.Add(sixthNumber);
            zipperedList = zipperedList.Zip(listOne, listTwo);
            actual = zipperedList.ToString();

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
