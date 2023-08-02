using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListsTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ToString_AListOfStringsReturnExpectedResult_ReturnTrue()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            string name1 = "Nick";
            string name2 = "Bob";
            string name3 = "Tom";
            string allNames = "";
            string allNamesFromCustomList = "";
            bool result = false;
            //Set
            names.Add(name1);
            names.Add(name2);
            names.Add(name3);

            allNames = $"{name1}{name2}{name3}";
            allNamesFromCustomList = names.ToString();
            result = allNames == allNamesFromCustomList;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_AListOfIntsReturnsExpectedResult_True()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            bool result = false;
            string numbersString = "";
            string numbersStringFromList = "";

            //Set 
            numbersString = $"{number1}{number2}{number3}";
            numbersStringFromList = numbers.ToString();
            result = numbersString == numbersStringFromList;
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_AnEmptyListReturnsAnEmptyString_ReturnTrue()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            string emptyString = "";
            string stringFromList = "Test";
            bool result = false;

            //Set
            stringFromList = names.ToString();
            result = emptyString == stringFromList;
            //Assert
            Assert.IsTrue(result);
        }
    }
}
