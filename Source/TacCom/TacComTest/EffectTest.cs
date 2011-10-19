using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TacCom;
using NUnit.Framework;

namespace TacComTest
{
    [TestFixture]
    public class EffectTest
    {
        [Test()]
        public void TestThatEffectInitializes()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatEffectHasAttribute()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
            Assert.AreEqual(target.GetAttribute(), "blah");
        }

        [Test()]
        public void TestThatEffectHasTurnDuration()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
            Assert.AreEqual(target.GetDuration(), 1);
        }

        [Test()]
        public void TestThatEffectHasMagnitude()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
            Assert.AreEqual(target.GetMagnitude(), 0.0);
        }

        [Test()]
        public void TestThatEffectHasReset()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
            Assert.AreEqual(target.GetReset(), true);
        }

        [Test()]
        public void TestThatEffectHasCharacter()
        {
            var target = new Effect("blah", 1, 0.0, true, new Character("Bob", null, 10, 10, 10, new Item(), "Warrior"));
            Assert.AreEqual(target.GetCharacter().GetCharacterName(), new Character("Bob", null, 10, 10, 10, new Item(), "Warrior").GetCharacterName());
        }

        [Test()]
        public void TestThatEffectHasResetIsTrue()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
            Assert.True(target.GetReset());
        }

        [Test()]
        public void TestThatEffectHasResetIsFalse()
        {
            var target = new Effect("blah", 1, 0.0, true, null);
        }

        [Test()]
        public void TestThatEffectApplyEffectDecreasesDurationByOne()
        {
            var target = new Effect("blah", 1, 0.0, true, new Character("Bob", null, 10, 10, 10, new Item(), "Warrior"));
            target.ApplyEffect();
            Assert.AreEqual(target.GetDuration(), 0);
        }

        [Test()]
        public void TestThatEffectApplyEffectDoesNotDecreaseDurationAfterItIsZero()
        {
            var target = new Effect("blah", 0, 0.0, true, new Character("Bob", null, 10, 10, 10, new Item(), "Warrior"));
            target.ApplyEffect();
            Assert.AreEqual(target.GetDuration(), 0);
        }

        [Test()]
        public void TestThatEffectApplyEffectIsAppliedToHealth()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new Effect("health", 1, 1.0, true, bob);
            target.ApplyEffect();
            Assert.AreEqual(target.GetCharacter().GetCharacterHitPoints(), bob.GetCharacterHitPoints()); 
        }

        [Test()]
        public void TestThatEffectApplyEffectIsAppliedToDodge()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var target = new Effect("dodge", 1, 1.0, true, bob);
            target.ApplyEffect();
            Assert.AreEqual(target.GetCharacter().GetCharacterDodgeChance(), bob.GetCharacterDodgeChance());
        }

        [Test()]
        public void TestThatSetTargetChangesTheTargetToTheCorrectTarget()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            var testEffect = new Effect("dodge", 1, 1.0, true, bob);
            var george = new Character("George", null, 10, 10, 10, new Item(), "Mage");
            testEffect.setTarget(george);
        }
    }
}
