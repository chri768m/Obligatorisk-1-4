using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorisk_opgave_beer;
using System;
using System.Collections.Generic;
using System.Text;

namespace obligatorisk_opgave_beer.Tests
{
    [TestClass()]
    public class BeerTests
    {
        Beer beer = new Beer(2,"hallenstern",150,45);
        [TestMethod()]
        public void ID()
        {
            //*Beer beer = new Beer();
            beer.ID = 1;
            Assert.AreEqual(expected: 1, actual: beer.ID);
            Assert.ThrowsException<ArgumentException>(()  =>beer.ID = - 1);
        }
        [TestMethod()]
        public void Name()
        {
            //*Beer beer = new Beer();
            beer.Name = "lagerbitches";
            Assert.AreEqual(expected: "lagerbitches", actual: beer.Name);
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "bic");
        }
        [TestMethod()]
        public void Price()
        {
            //*Beer beer = new Beer();
            beer.Price = 100;
            Assert.AreEqual(expected: 100, actual: beer.Price);
            Assert.ThrowsException<ArgumentException>(() => beer.Price = -1);
        }
        [TestMethod()]
        public void ABV()
        {
            //*Beer beer = new Beer();
            beer.ABV = 25;
            Assert.AreEqual(expected: 25, actual: beer.ABV);
            beer.ABV = 0;
            Assert.AreEqual(expected: 0, actual: beer.ABV);
            beer.ABV = 100;
            Assert.AreEqual(expected: 100, actual: beer.ABV);
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> beer.ABV = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.ABV = 101);
            
        }
    }
}