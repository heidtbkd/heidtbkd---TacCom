using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TacCom;

namespace TacComTest
{
    [TestFixture]
    public class CharAbilityTest
    {
        [Test()]
        public void TestThatCharAbilityInitializes()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",50, bob);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectAbilityName()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",50, bob);
            Assert.AreEqual(target.getAbilityName(),"Fire");
        }

        [Test()]
        public void TestThatCharAbilityHasEmptyAbilityEffects()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",50, bob);
            Assert.IsNull(target.getAbilityEffect());
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",50, bob);
            Assert.AreEqual(target.getMPCost(), 50);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCostAboveMaxCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",101, bob);
            Assert.AreEqual(target.getMPCost(), 100);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCostBelowMinCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",-1, bob);
            Assert.AreEqual(target.getMPCost(), 1);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCostWithZeroCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",0, bob);
            Assert.AreEqual(target.getMPCost(), 1);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCostWithHalfCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",50, bob);
            Assert.AreEqual(target.getMPCost(), 50);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCostWithMinCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",1, bob);
            Assert.AreEqual(target.getMPCost(), 1);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectMPCostWithMaxCost()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new CharAbility("Fire", null, "spell",100, bob);
            Assert.AreEqual(target.getMPCost(), 100);
        }

        /// <summary>
        /// New tests for 4-29
        /// </summary>
        
        [Test()]
        public void TestThatCharAbilityHasCorrectEffect()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("blah", 1, 0.0, true, bob);
            var target = new CharAbility("Fire", blah, "spell",1, bob);
            Assert.AreEqual(target.getAbilityEffect(), blah);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectTarget()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("blah", 1, 0.0, true, bob);
            var target = new CharAbility("Fire", blah, "spell",1, bob);
            Assert.AreEqual(target.getAbilityChar(), bob);
        }

        [Test()]
        public void TestThatCharAbilityHasCorrectModifier()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("blah", 1, 0.0, true, bob);
            var target = new CharAbility("Fire", blah, "spell", 1, bob);
        }
    }
}
