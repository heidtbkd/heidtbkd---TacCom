using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TacCom;

namespace TacComTest
{
    /// <summary>
    /// New test for 4-29
    /// </summary>

    [TestFixture]
    public class EnvironmentTest
    {
        [Test()]
        public void TestThatEnvironmentInitializes()
        {
            var target = new Environments("shine", null);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatEnvironmentHasWeatherName()
        {
            var target = new Environments("shine", null);
            Assert.AreEqual(target.getEnvName(), "shine");
        }

        [Test()]
        public void TestThatEnvironmentHasWeatherAbility()
        {
            Effect blah = new Effect("blah", 1, 0.0, true, null);
            var target = new Environments("shine", blah);
            Assert.AreEqual(target.getWeatherAbility(), blah); 
        }
    }
}
