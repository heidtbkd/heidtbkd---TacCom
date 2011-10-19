using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Microsoft.Win32;
using TacCom;

namespace TacComTest
{
    [TestFixture]
    public class CharacterTest
    {
        [Test()]
        public void TestThatCharacterInitializes()
        {
            var target = new Character("Bob", null,10,10,10, new Item(), "Warrior");
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatCharacterHasCorrectName()
        {
            var target = new Character("Bob", null,10,10,10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterName(), "Bob");
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeArray()
        {
            int[] attributes = new int[3]{10,10,10};
            var target = new Character("Bob", null,10,10,10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterAttributes(), attributes);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeStrength()
        {
            int[] attributes = new int[3] { 10, 10, 10 };
            
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[0], attributes[0]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeIntelligence()
        {
            int[] attributes = new int[3] { 10, 10, 10 };

            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[1], attributes[1]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeAgility()
        {
            int[] attributes = new int[3] { 10, 10, 10 };

            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[2], attributes[2]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectHitPoints()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterHitPoints(),100);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPoints()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterMagicPoints(), 100);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttackPower()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterAttackPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasCorrectSpellPower()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterSpellPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasCorrectDodgeChance()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterDodgeChance(), (10* 0.04));
        }

        [Test()]
        public void TestThatCharacterHasCorrectCriticalChance()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterCriticalChance(), (10 * 0.06));
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeIntelligenceAtZero()
        {
            int[] attributes = new int[3] { 5, 1, 5 };

            var target = new Character("Bob", null, 5, 0, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[1], attributes[1]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeAgilityAtZero()
        {
            int[] attributes = new int[3] { 5, 5, 1 };

            var target = new Character("Bob", null, 5, 5, 0, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[2], attributes[2]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeStrengthAtZero()
        {
            int[] attributes = new int[3] { 1, 5, 5 };

            var target = new Character("Bob", null, 0, 5, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[0], attributes[0]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeIntelligenceAtOne()
        {
            int[] attributes = new int[3] { 5, 1, 5 };

            var target = new Character("Bob", null, 5, 1, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[1], attributes[1]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeAgilityAtOne()
        {
            int[] attributes = new int[3] { 5, 5, 1 };

            var target = new Character("Bob", null, 5, 5, 1, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[2], attributes[2]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeStrengthAtOne()
        {
            int[] attributes = new int[3] { 1, 5, 5 };

            var target = new Character("Bob", null, 1, 5, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[0], attributes[0]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeIntelligenceAtMax()
        {
            int[] attributes = new int[3] { 5, 10, 5 };

            var target = new Character("Bob", null, 5, 10, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[1], attributes[1]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeAgilityAtMax()
        {
            int[] attributes = new int[3] { 5, 5, 10 };

            var target = new Character("Bob", null, 5, 5, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[2], attributes[2]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeStrengthAtMax()
        {
            int[] attributes = new int[3] { 10, 5, 5 };

            var target = new Character("Bob", null, 10, 5, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[0], attributes[0]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeIntelligenceAtNine()
        {
            int[] attributes = new int[3] { 5, 9, 5 };

            var target = new Character("Bob", null, 5, 9, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[1], attributes[1]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeAgilityAtNine()
        {
            int[] attributes = new int[3] { 5, 5, 9 };

            var target = new Character("Bob", null, 5, 5, 9, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[2], attributes[2]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttributeStrengthAtNine()
        {
            int[] attributes = new int[3] { 9, 5, 5 };

            var target = new Character("Bob", null, 9, 5, 5, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterAttributes();
            Assert.AreEqual(targetAttribute[0], attributes[0]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectHitPointsAfterDeductingZero()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterHitPoints(0);
            Assert.AreEqual(target.GetCharacterHitPoints(), 100); 
        }

        [Test()]
        public void TestThatCharacterHasCorrectHitPointsAfterDeductingOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterHitPoints(1);
            Assert.AreEqual(target.GetCharacterHitPoints(), 99);
        }

        [Test()]
        public void TestThatCharacterHasCorrectHitPointsAfterDeductingHalf()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterHitPoints(50);
            Assert.AreEqual(target.GetCharacterHitPoints(), 50);
        }

        [Test()]
        public void TestThatCharacterHasCorrectHitPointsAfterDeductingAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterHitPoints(100);
            Assert.AreEqual(target.GetCharacterHitPoints(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPointsAfterDeductingZero()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("magicPoints",0);
            Assert.AreEqual(target.GetCharacterMagicPoints(), 100);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPointsAfterDeductingOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("magicPoints",1);
            Assert.AreEqual(target.GetCharacterMagicPoints(), 99);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPointsAfterDeductingHalf()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("magicPoints",50);
            Assert.AreEqual(target.GetCharacterMagicPoints(), 50);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPointsAfterDeductingAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("magicPoints",100);
            Assert.AreEqual(target.GetCharacterMagicPoints(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPointsAfterDeductingNegativeOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("magicPoints", -1);
            Assert.AreEqual(target.GetCharacterMagicPoints(), 100);
        }

        [Test()]
        public void TestThatCharacterHasCorrectMagicPointsAfterDeductingOverAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("magicPoints", 101);
            Assert.AreEqual(target.GetCharacterMagicPoints(), 0);
        }

        [Test()]
        public void TestThatCharacterHasZeroAttackPower()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("attackPower", 20);
            Assert.AreEqual(target.GetCharacterAttackPower(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttackPowerAfterDeductingHalf()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("attackPower", 10);
            Assert.AreEqual(target.GetCharacterAttackPower(), 10);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttackPowerAfterDeductingNegativeOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("attackPower", -1);
            Assert.AreEqual(target.GetCharacterAttackPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttackPowerAfterDeductingOverAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("attackPower", 21);
            Assert.AreEqual(target.GetCharacterAttackPower(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectAttackPowerAfterDeductingZero()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("attackPower", 0);
            Assert.AreEqual(target.GetCharacterAttackPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasZeroSpellPower()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("spellPower", 20);
            Assert.AreEqual(target.GetCharacterSpellPower(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectSpellPowerAfterDeductingHalf()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("spellPower", 10);
            Assert.AreEqual(target.GetCharacterSpellPower(), 10);
        }

        [Test()]
        public void TestThatCharacterHasCorrectSpellPowerAfterDeductingNegativeOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("spellPower", -1);
            Assert.AreEqual(target.GetCharacterSpellPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasCorrectSpellPowerAfterDeductingOverAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("spellPower", 21);
            Assert.AreEqual(target.GetCharacterSpellPower(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectSpellPowerAfterDeductingZero()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("spellPower", 0);
            Assert.AreEqual(target.GetCharacterSpellPower(), 20);
        }


        [Test()]
        public void TestThatCharacterHasZeroDodgeChance()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("dodgeChance", 10 * .04);
            Assert.AreEqual(target.GetCharacterDodgeChance(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectDodgeChanceAfterDeductingHalf()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("dodgeChance", 5 * .04);
            Assert.AreEqual(target.GetCharacterDodgeChance(), (10 * .04 - 5 * .04));
        }

        [Test()]
        public void TestThatCharacterHasCorrectDodgeChanceAfterDeductingNegativeOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("dodgeChance", -1.0);
            Assert.AreEqual(target.GetCharacterDodgeChance(), 10 * .04);
        }

        [Test()]
        public void TestThatCharacterHasCorrectDodgeChanceAfterDeductingOverAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("dodgeChance", 11 * .04);
            Assert.AreEqual(target.GetCharacterDodgeChance(), 0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectDodgeChanceAfterDeductingZero()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("dodgeChance", 0.0);
            Assert.AreEqual(target.GetCharacterDodgeChance(), 10 * .04);
        }


        [Test()]
        public void TestThatCharacterHasZeroCritChance()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("critChance", 10 * .06);
            Assert.AreEqual(target.GetCharacterCriticalChance(), 0.0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectCritChanceAfterDeductingHalf()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("critChance", 5 * .06);
            Assert.AreEqual(target.GetCharacterCriticalChance(), ((10 * .06) - (5 * .06)));
        }

        [Test()]
        public void TestThatCharacterHasCorrectCritChanceAfterDeductingNegativeOne()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("critChance", -1.0);
            Assert.AreEqual(target.GetCharacterCriticalChance(), 10 * .06);
        }

        [Test()]
        public void TestThatCharacterHasCorrectCritChangeAfterDeductingOverAll()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("critChance", 11 * .06);
            Assert.AreEqual(target.GetCharacterCriticalChance(), 0.0);
        }

        [Test()]
        public void TestThatCharacterHasCorrectCritChanceAfterDeductingZero()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.DeductCharacterStat("critChance", 0.0);
            Assert.AreEqual(target.GetCharacterCriticalChance(), 10 * .06);
        }

        [Test()]
        public void TestThatCharacterHasImageIsNull()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.IsNull(target.GetCharacterImage());
        }

        /// <summary>
        /// These are the new tests 4-29
        /// </summary>

        [Test()]
        public void TestThatCharacterHasCorrectInitialAttributeArray()
        {
            int[] attributes = new int[3] { 10, 10, 10 };
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialAttributes(), attributes);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialAttributeStrength()
        {
            int[] attributes = new int[3] { 10, 10, 10 };

            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterInitialAttributes();
            Assert.AreEqual(targetAttribute[0], attributes[0]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialAttributeIntelligence()
        {
            int[] attributes = new int[3] { 10, 10, 10 };

            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterInitialAttributes();
            Assert.AreEqual(targetAttribute[1], attributes[1]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialAttributeAgility()
        {
            int[] attributes = new int[3] { 10, 10, 10 };

            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            int[] targetAttribute = target.GetCharacterInitialAttributes();
            Assert.AreEqual(targetAttribute[2], attributes[2]);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialHitPoints()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialHitPoints(), 100);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialMagicPoints()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialMagicPoints(), 100);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialAttackPower()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialAttackPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialSpellPower()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialSpellPower(), 20);
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialDodgeChance()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialDodgeChance(), (10 * 0.04));
        }

        [Test()]
        public void TestThatCharacterHasCorrectInitialCriticalChance()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Assert.AreEqual(target.GetCharacterInitialCriticalChance(), (10 * 0.06));
        }

        [Test()]
        public void TestThatCharacterIsDead()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            target.SetDead();
            Assert.AreEqual(target.GetDead(), true);
        }

        [Test()]
        public void TestThatCharacterIsDeadAfterTakingDamage()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");

            target.DeductCharacterHitPoints(100);
            Assert.AreEqual(target.GetDead(), true);
        }

        [Test()]
        public void TestThatSetAbility1SetsTheAbilityListCorrectly()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            CharAbility ca = new CharAbility("Hit", new Effect("health", 1, 10, false, null), "attack", 10, null);
            target.SetFirstAbilityForCharacter(ca);
            Assert.AreEqual(target.GetCharacterAbilities()[0], ca);
        }

        [Test()]
        public void TestThatSetAbility2SetsTheAbilityListCorrectly()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            CharAbility ca = new CharAbility("Hit", new Effect("health", 1, 10, false, null), "attack", 10, null);
            target.SetSecondAbilityForCharacter(ca);
            Assert.AreEqual(target.GetCharacterAbilities()[1], ca);
        }

        [Test()]
        public void TestThatSetAbility3SetsTheAbilityListCorrectly()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            CharAbility ca = new CharAbility("Hit", new Effect("health", 1, 10, false, null), "attack", 10, null);
            target.SetThirdAbilityForCharacter(ca);
            Assert.AreEqual(target.GetCharacterAbilities()[2], ca);
        }

        [Test()]
        public void TestThatSetAbility4SetsTheAbilityListCorrectly()
        {
            var target = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            CharAbility ca = new CharAbility("Hit", new Effect("health", 1, 10, false, null), "attack", 10, null);
            target.SetFourthAbilityForCharacter(ca);
            Assert.AreEqual(target.GetCharacterAbilities()[3], ca);
        }
    }
}
