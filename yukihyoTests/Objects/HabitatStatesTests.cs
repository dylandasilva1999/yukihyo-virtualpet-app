using NUnit.Framework;
using yukihyo.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects.Tests
{
    [TestFixture()]
    public class HabitatStatesTests
    {
        [Test()]
        public void GetHabitatStringTest()
        {
            //ARRANGE
            string yukihyoString = "neutral";
            var expectedState = YukihyoState.neutral;

            //ACT
            var result = YukihyoStates.GetYukihyoState(yukihyoString);

            //ASSERT
            Assert.AreEqual(expectedState, result);
        }

        [Test()]
        public void GetHabitatStateTest()
        {
            //ARRANGE
            string yukihyoString = "neutral";
            var expectedState = YukihyoState.neutral;

            //ACT
            var result = YukihyoStates.GetYukihyoState(yukihyoString);

            //ASSERT
            Assert.AreEqual(expectedState, result);
        }
    }
}