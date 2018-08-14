
using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentValueTests
    {
        #region Public Methods

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(Int32.MinValue, Int32.MaxValue)]
        public void ThrowIfIsLessThan_IntInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(int inst, int lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(UInt32.MinValue, UInt32.MaxValue)]
        public void ThrowIfIsLessThan_IntInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        #endregion
    }

    #endregion
}