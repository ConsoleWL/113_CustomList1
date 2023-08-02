using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CustomListsTests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Remove_CountDecremeantingWhenItemAdded_ReturnTrue()
        {
            // Arange
            CustomList<string> names = new CustomList<string>();
            names.Add("Tom");
            names.Add("Bob");
            names.Add("Bob");
            names.Add("Bob");
            int countBeforeRemove = names.Count;
            int countAfterRemove;

            // Set
            names.Remove("Tom");
            countAfterRemove = names.Count;

            // Assert
            Assert.IsTrue(countBeforeRemove > countAfterRemove);
        }

        [TestMethod]
        public void Remove_WhenRemoveItemSuccesfuly_ReturnTrue()
        {
            // Arange
            CustomList<string> names = new CustomList<string>();
            names.Add("Tom");
            names.Add("Bob");
            names.Add("Tom");
            bool result = false;
            //Set
            result = names.Remove("Bob");
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Remove_CountDoesNotDecrementIfCouldNotRemoveItem_CountStaysTheSame()
        {
            // Arrange
            CustomList<string> names = new CustomList<string>();
            names.Add("Bob");
            names.Add("Bob");
            names.Add("Bob");
            int countBeforeRemoving = names.Count;

            // Set
            names.Remove("Tom");

            // Assert
            Assert.AreEqual(countBeforeRemoving, names.Count);
        }

        [TestMethod]
        public void Remove_ItemsShiftBackwardsAfterRemovingOneItem_IndexOneEqualsIndexTwo()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            names.Add("Nikita");
            names.Add("Bob");
            names.Add("Tom");
            string name = names[1];

            //Set
            names.Remove("Nikita");

            //Assert
            Assert.AreEqual(name, names[0]);
        }

        [TestMethod]
        public void Remove_RemoveOnlyFirstItemWithTheSameName_ReturnTrue()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            names.Add("Bob");
            names.Add("Bob");
            names.Add("Bob");
            string name1 = names[1];
            string name2 = names[2];
            bool result = false;
           
            //Set
            names.Remove("Bob");
            result = "Bob" == names[0];
            result = "Bob" == names[1];

            //Assert
            Assert.IsTrue(result);
        }
    }
}
