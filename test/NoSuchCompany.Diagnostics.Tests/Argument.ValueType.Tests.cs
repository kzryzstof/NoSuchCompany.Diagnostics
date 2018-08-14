// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 14/08/2018 @ 7:21 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentValueTypeTests
    {
        #region Public Methods

        [Theory]
        [InlineData(0.0000000000000001, 0.0000000000000000)]
        [InlineData((double) 0, (double) -1)]
        [InlineData((double) 1, (double) 0)]
        [InlineData(double.MaxValue, double.MinValue)]
        public void ThrowIfIsLessThan_DoubleInstIsGreaterThanLowerBound_NoExceptionThrown(double inst, double lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0.0000000000000000, 0.0000000000000001)]
        [InlineData((double) -1, (double) 0)]
        [InlineData((double) 0, (double) 1)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void ThrowIfIsLessThan_DoubleInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(double inst, double lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((float) 0.0000001, (float) 0.0000000)]
        [InlineData((float) 0, (float) -1)]
        [InlineData((float) 1, (float) 0)]
        [InlineData(float.MaxValue, float.MinValue)]
        public void ThrowIfIsLessThan_FloatInstIsGreaterThanLowerBound_NoExceptionThrown(float inst, float lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((float) 0.0000000, (float) 0.0000001)]
        [InlineData((float) -1, (float) 0)]
        [InlineData((float) 0, (float) 1)]
        [InlineData(float.MinValue, float.MaxValue)]
        public void ThrowIfIsLessThan_FloatInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(float inst, float lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(1, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void ThrowIfIsLessThan_IntInstIsGreaterThanLowerBound_NoExceptionThrown(int inst, int lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void ThrowIfIsLessThan_IntInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(int inst, int lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((long) 0, (long) -1)]
        [InlineData((long) 1, (long) 0)]
        [InlineData(long.MaxValue, long.MinValue)]
        public void ThrowIfIsLessThan_LongInstIsGreaterThanLowerBound_NoExceptionThrown(long inst, long lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((long) -1, (long) 0)]
        [InlineData((long) 0, (long) 1)]
        [InlineData(long.MinValue, long.MaxValue)]
        public void ThrowIfIsLessThan_LongInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(long inst, long lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((short) 0, (short) -1)]
        [InlineData((short) 1, (short) 0)]
        [InlineData(short.MaxValue, short.MinValue)]
        public void ThrowIfIsLessThan_ShortInstIsGreaterThanLowerBound_NoExceptionThrown(short inst, short lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((short) -1, (short) 0)]
        [InlineData((short) 0, (short) 1)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void ThrowIfIsLessThan_ShortInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(short inst, short lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(uint.MaxValue, uint.MinValue)]
        public void ThrowIfIsLessThan_UIntInstIsGreaterThanLowerBound_NoExceptionThrown(uint inst, uint lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void ThrowIfIsLessThan_UIntInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ulong) 1, (ulong) 0)]
        [InlineData(ulong.MaxValue, ulong.MinValue)]
        public void ThrowIfIsLessThan_ULongInstIsGreaterThanLowerBound_NoExceptionThrown(ulong inst, ulong lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ulong) 0, (ulong) 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        public void ThrowIfIsLessThan_ULongInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ushort) 1, (ushort) 0)]
        [InlineData(ushort.MaxValue, ushort.MinValue)]
        public void ThrowIfIsLessThan_UShortInstIsGreaterThanLowerBound_NoExceptionThrown(ushort inst, ushort lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ushort) 0, (ushort) 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        public void ThrowIfIsLessThan_UShortInstIsLessThanLowerBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        #endregion
    }

    #endregion
}