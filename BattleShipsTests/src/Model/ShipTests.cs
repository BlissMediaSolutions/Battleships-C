using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ShipTests
    {
        [TestMethod()]
        public void ShipTest()
        {
            Ship ship = new Ship(ShipName.Tug);
            Assert.AreEqual(ship.Name, "Tug");
            Assert.AreEqual(ship.Size, 1);
            Assert.AreNotEqual(ship.Name, "Harry");
            Assert.AreNotEqual(ship.Size, 3);
        }

        [TestMethod()]
        public void AddTileTest()
        {
            Ship shipA = new Ship(ShipName.Tug);
            Ship shipB = new Ship(ShipName.Destroyer);
            Tile thisTile = new Tile(1, 1, shipA);
            Tile anotherTile = new Tile(10, 10, shipB);
            Assert.AreEqual(thisTile.Ship.Name, "Tug");
            Assert.AreEqual(anotherTile.Ship.Name, "Destroyer");
            Assert.AreNotEqual(thisTile.Ship.Name, "Nothing");
            
        }

       // [TestMethod()]
        //public void RemoveTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void HitTest()
        //{

        //    Assert.Fail();
        //}
    }
}