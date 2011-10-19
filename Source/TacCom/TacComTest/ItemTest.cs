using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TacCom;
using NUnit.Framework;

namespace TacComTest
{
    [TestFixture]
    public class ItemTest
    {
        [Test()]
        public void TestThatItemInitializes()
        {
            var target = new Item("Sword", "weapon", null);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatItemHasCorrectName()
        {
            var target = new Item("Sword", "weapon", null);
            Assert.AreEqual(target.getItemName(), "Sword"); 
        }

        [Test()]
        public void TestThatItemHasCorrectType()
        {
            var target = new Item("Sword", "weapon", null);
            Assert.AreEqual(target.getItemType(), "weapon");
        }

        [Test()]
        public void TestThatItemHasNullAbility()
        {
            var target = new Item("Sword", "weapon", null);
            Assert.IsNull(target.getItemAbility());
        }
    }
}
