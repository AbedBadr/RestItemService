using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib.Model;
using RestItemService.Controllers;

namespace ItemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllTest()
        {
            //ARRANGE
            ItemsController controller = new ItemsController();

            //ACT
            IEnumerable<Item> itemsList = controller.Get();

            //ASSERT
            Assert.AreEqual(itemsList, ItemsController.items);
        }

        [TestMethod]
        public void GetSpecificTest()
        {
            //ARRANGE
            ItemsController controller = new ItemsController();
            Item expected = new Item(4, "Soda", "High", 21.4);

            //ACT
            Item actual = controller.Get(4);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFromSubstringTest()
        {
            //ARRANGE
            ItemsController controller = new ItemsController();
            IEnumerable<Item> expectedList = new List<Item>(){new Item(1, "Bread", "Low", 33), new Item(2, "Bread", "Middle", 21)};

            //ACT
            IEnumerable<Item> actualList = controller.GetFromSubstring("Bread");

            //ASSERT
            Assert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void SearchQuantityTest()
        {
            //ARRANGE
            ItemsController controller = new ItemsController();

            //ACT


            //ASSERT

        }

        [TestMethod]
        public void PostTest()
        {
            //ARRANGE
            ItemsController controller = new ItemsController();
            Item postItem = new Item(6, "Coca", "High", 55);

            //ACT
            controller.Post(postItem);

            //ASSERT
            Assert.AreEqual(controller.Get(6), postItem);
        }

        [TestMethod]
        public void PutTest()
        {
            //ARRANGE
            ItemsController controller = new ItemsController();
            Item putItem = new Item(6, "Coca Cola", "High", 55);

            //ACT
            controller.Put(6, putItem);

            //ASSERT
            Assert.AreEqual(controller.Get(6), putItem);
        }

        [TestMethod]
        public void DeleteTest()
        {
            //ARRANGE


            //ACT


            //ASSERT

        }

    }
}
