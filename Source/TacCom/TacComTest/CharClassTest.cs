using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TacCom;
using NUnit.Framework;

namespace TacComTest
{
    [TestFixture]
    public class CharClassTest
    {
        [Test()]
        public void TestThatCharClassInitializes()
        {
            var target = new CharClass("Wizard", null);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatCharClassHasAClassName()
        {
            var target = new CharClass("Warrior", null);
            Assert.AreEqual(target.getClassName(), "Warrior");
        }

        [Test()]
        public void TestThatCharClassHasACorrectClassNameWhenMage()
        {
            var target = new CharClass("Mage", null);
            Assert.AreEqual(target.getClassName(), "Mage");
        }

        [Test()]
        public void TestThatCharClassHasACorrectClassNameWhenBattleMage()
        {
            var target = new CharClass("Battle Mage", null);
            Assert.AreEqual(target.getClassName(), "Battle Mage");
        }

        [Test()]
        public void TestThatCharClassHasACorrectClassNameWhenWarrior()
        {
            var target = new CharClass("Warrior", null);
            Assert.AreEqual(target.getClassName(), "Warrior");
        }

        [Test()]
        public void TestThatCharClassHasClassNameWhenNotValid()
        {
            var target = new CharClass("Wizard", null);
            Assert.AreEqual(target.getClassName(), "Battle Mage");
        }

        /// <summary>
        /// These are the new 4-29 tests
        /// </summary>

        [Test()]
        public void TestThatCharClassHasAFirstAbility()
        {
            var target = new CharClass("Warrior", null);
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility[] targ2 = target.getCharacterAbilities();
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            Assert.AreEqual(targ2[0].getAbilityName(), blahAb.getAbilityName());
        }

        [Test()]
        public void TestThatCharClassHasASecondAbility()
        {
            var target = new CharClass("Warrior", null);
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility[] targ2 = target.getCharacterAbilities();
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            Assert.AreEqual(targ2[1].getAbilityName(), blahAb.getAbilityName());
        }

        [Test()]
        public void TestThatCharClassHasAThirdAbility()
        {
            var target = new CharClass("Warrior", null);
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility[] targ2 = target.getCharacterAbilities();
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            Assert.AreEqual(targ2[2].getAbilityName(), blahAb.getAbilityName());
        }

        [Test()]
        public void TestThatCharClassHasAFourthAbility()
        {
            var target = new CharClass("Warrior", null);
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility[] targ2 = target.getCharacterAbilities();
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            Assert.AreEqual(targ2[3].getAbilityName(), blahAb.getAbilityName());
        }
    }
}
