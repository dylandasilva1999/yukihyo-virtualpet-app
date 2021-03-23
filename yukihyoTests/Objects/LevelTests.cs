using NUnit.Framework;
using yukihyo.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects.Tests
{
    [TestFixture()]
    public class LevelTests
    {
        [Test()]
        public void GetLevelFromXpTest()
        {
            //ARRANGE
            int xp = 1500;
            int expectedLevel = 1;

            //ACT
            var result = Level.GetLevelFromXp(xp);

            //ASSERT
            Assert.AreEqual(expectedLevel, result);
        }

        [Test()]
        public void GetHungerLevelFromXpTest()
        {
            //ARRANGE
            int xp = 1500;
            int expectedLevel = 2;

            //ACT
            var result = Level.GetHungerLevelFromXp(xp);

            //ASSERT
            Assert.AreEqual(expectedLevel, result);
        }

        [Test()]
        public void GetHabitatLevelFromXpTest()
        {
            //ARRANGE
            int xp = 1500;
            int expectedLevel = 2;

            //ACT
            var result = Level.GetHabitatLevelFromXp(xp);

            //ASSERT
            Assert.AreEqual(expectedLevel, result);
        }

        [Test()]
        public void GetSafetyLevelFromXpTest()
        {
            //ARRANGE
            int xp = 1500;
            int expectedLevel = 2;

            //ACT
            var result = Level.GetSafetyLevelFromXp(xp);

            //ASSERT
            Assert.AreEqual(expectedLevel, result);
        }
    }
}