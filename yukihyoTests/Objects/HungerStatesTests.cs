using NUnit.Framework;
using yukihyo.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects.Tests
{
    [TestFixture()]
    public class HungerStatesTests
    {
        [Test()]
        public void GetHungerStringTest()
        {
            //ARRANGE
            string yukihyoString = "sad";
            var expectedState = YukihyoState.sad;

            //ACT
            var result = YukihyoStates.GetYukihyoState(yukihyoString);

            //ASSERT
            Assert.AreEqual(expectedState, result);
        }

        [Test()]
        public void GetHungerStateTest()
        {
            //ARRANGE
            string yukihyoString = "sad";
            var expectedState = YukihyoState.sad;

            //ACT
            var result = YukihyoStates.GetYukihyoState(yukihyoString);

            //ASSERT
            Assert.AreEqual(expectedState, result);
        }
    }
}