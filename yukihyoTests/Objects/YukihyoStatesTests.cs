using NUnit.Framework;
using yukihyo.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects.Tests
{
    [TestFixture()]
    public class YukihyoStatesTests
    {
        [Test()]
        public void GetYukihyoStringTest()
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
        public void GetYukihyoStateTest()
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