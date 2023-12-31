﻿using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListsTests
{
    [TestClass]
    public class MinusOperatorTests
    {
        [TestMethod]
        public void MinusOperator_FirstListIsLongerThanSecondList_ReturnTrue()
        {
            //Arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(1);
            numbers1.Add(2);

            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(1);

            bool result = false;

            //Set
            result = numbers1.Count > numbers2.Count;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MinusOperator_SecondListIsLongerThanFirstList_ReturnTrue()
        {
            //Arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(1);

            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(1);
            numbers2.Add(2);

            bool result = false;

            //Set
            result = numbers2.Count > numbers1.Count;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MinusOperator_IsSecondListIsEmptyResultIsUnchanged_ReturnTrue()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            CustomList<int> numbers2 = new CustomList<int>();
            bool result = false;

            //Set
            CustomList<int> numbers3 = numbers - numbers2;

            result = numbers.Count == numbers3.Count;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MinusOperator_RemoveOnlyInstancesThatAreInList_ReturnTrue()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(3);
            numbers.Add(3);
            numbers.Add(3);

            CustomList<int> numbers2 = new CustomList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            bool result = false;

            //Set
            CustomList<int> numbers3 = numbers - numbers2;
            result = numbers3[0] == numbers3[1];

            //Assert
            Assert.IsTrue(result);
        }
    }
}
