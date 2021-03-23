using NUnit.Framework;
using yukihyo.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects.Tests
{
    [TestFixture()]
    public class SafetyStatesTests
    {
        [Test()]
        public void GetSafetyStringTest()
        {
            //ARRANGE
            string yukihyoString = "happy";
            var expectedState = YukihyoState.happy;

            //ACT
            var result = YukihyoStates.GetYukihyoState(yukihyoString);

            //ASSERT
            Assert.AreEqual(expectedState, result);
        }

        [Test()]
        public void GetSafetyStateTest()
        {
            //ARRANGE
            string yukihyoString = "happy";
            var expectedState = YukihyoState.happy;

            //ACT
            var result = YukihyoStates.GetYukihyoState(yukihyoString);

            //ASSERT
            Assert.AreEqual(expectedState, result);
        }
    }
}