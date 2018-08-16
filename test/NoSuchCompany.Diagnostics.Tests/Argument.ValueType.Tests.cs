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
        public void ThrowIfIsLowerThan_DoubleInstIsGreaterThanLowerBound_NoExceptionThrown(double inst, double lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0.0000000000000000, 0.0000000000000001)]
        [InlineData((double) -1, (double) 0)]
        [InlineData((double) 0, (double) 1)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void ThrowIfIsLowerThan_DoubleInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(double inst, double lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((float) 0.0000001, (float) 0.0000000)]
        [InlineData((float) 0, (float) -1)]
        [InlineData((float) 1, (float) 0)]
        [InlineData(float.MaxValue, float.MinValue)]
        public void ThrowIfIsLowerThan_FloatInstIsGreaterThanLowerBound_NoExceptionThrown(float inst, float lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((float) 0.0000000, (float) 0.0000001)]
        [InlineData((float) -1, (float) 0)]
        [InlineData((float) 0, (float) 1)]
        [InlineData(float.MinValue, float.MaxValue)]
        public void ThrowIfIsLowerThan_FloatInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(float inst, float lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(1, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void ThrowIfIsLowerThan_IntInstIsGreaterThanLowerBound_NoExceptionThrown(int inst, int lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void ThrowIfIsLowerThan_IntInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(int inst, int lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((long) 0, (long) -1)]
        [InlineData((long) 1, (long) 0)]
        [InlineData(long.MaxValue, long.MinValue)]
        public void ThrowIfIsLowerThan_LongInstIsGreaterThanLowerBound_NoExceptionThrown(long inst, long lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((long) -1, (long) 0)]
        [InlineData((long) 0, (long) 1)]
        [InlineData(long.MinValue, long.MaxValue)]
        public void ThrowIfIsLowerThan_LongInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(long inst, long lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((short) 0, (short) -1)]
        [InlineData((short) 1, (short) 0)]
        [InlineData(short.MaxValue, short.MinValue)]
        public void ThrowIfIsLowerThan_ShortInstIsGreaterThanLowerBound_NoExceptionThrown(short inst, short lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((short) -1, (short) 0)]
        [InlineData((short) 0, (short) 1)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void ThrowIfIsLowerThan_ShortInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(short inst, short lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(uint.MaxValue, uint.MinValue)]
        public void ThrowIfIsLowerThan_UIntInstIsGreaterThanLowerBound_NoExceptionThrown(uint inst, uint lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void ThrowIfIsLowerThan_UIntInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ulong) 1, (ulong) 0)]
        [InlineData(ulong.MaxValue, ulong.MinValue)]
        public void ThrowIfIsLowerThan_ULongInstIsGreaterThanLowerBound_NoExceptionThrown(ulong inst, ulong lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ulong) 0, (ulong) 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        public void ThrowIfIsLowerThan_ULongInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ushort) 1, (ushort) 0)]
        [InlineData(ushort.MaxValue, ushort.MinValue)]
        public void ThrowIfIsLowerThan_UShortInstIsGreaterThanLowerBound_NoExceptionThrown(ushort inst, ushort lowerBound)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ushort) 0, (ushort) 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        public void ThrowIfIsLowerThan_UShortInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        #endregion

        [Theory]
        [InlineData(0.000000000000001, 0.0000000000000000)]
        [InlineData((double) 0, (double) -1)]
        [InlineData((double) 1, (double) 0)]
        [InlineData(double.MaxValue, double.MinValue)]
        public void ThrowIfIsGreaterThan_DoubleInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(double inst, double upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData(0.0000000000000000, 0.0000000000000001)]
        [InlineData((double) -1, (double) 0)]
        [InlineData((double) 0, (double) 1)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void ThrowIfIsGreaterThan_DoubleInstIsLowerThanUpperBound_NoExceptionThrown(double inst, double upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((float) 0.0000001, (float) 0.0000000)]
        [InlineData((float) 0, (float) -1)]
        [InlineData((float) 1, (float) 0)]
        [InlineData(float.MaxValue, float.MinValue)]
        public void ThrowIfIsGreaterThan_FloatInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(float inst, float upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((float) 0.0000000, (float) 0.0000001)]
        [InlineData((float) -1, (float) 0)]
        [InlineData((float) 0, (float) 1)]
        [InlineData(float.MinValue, float.MaxValue)]
        public void ThrowIfIsGreaterThan_FloatInstIsLowerThanUpperBound_NoExceptionThrown(float inst, float upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(1, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void ThrowIfIsGreaterThan_IntInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(int inst, int upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void ThrowIfIsGreaterThan_IntInstIsLowerThanUpperBound_NoExceptionThrown(int inst, int upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((long) 0, (long) -1)]
        [InlineData((long) 1, (long) 0)]
        [InlineData(long.MaxValue, long.MinValue)]
        public void ThrowIfIsGreaterThan_LongInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(long inst, long upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((long) -1, (long) 0)]
        [InlineData((long) 0, (long) 1)]
        [InlineData(long.MinValue, long.MaxValue)]
        public void ThrowIfIsGreaterThan_LongInstIsLowerThanUpperBound_NoExceptionThrown(long inst, long upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((short) 0, (short) -1)]
        [InlineData((short) 1, (short) 0)]
        [InlineData(short.MaxValue, short.MinValue)]
        public void ThrowIfIsGreaterThan_ShortInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(short inst, short upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((short) -1, (short) 0)]
        [InlineData((short) 0, (short) 1)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void ThrowIfIsGreaterThan_ShortInstIsLowerThanUpperBound_NoExceptionThrown(short inst, short upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(uint.MaxValue, uint.MinValue)]
        public void ThrowIfIsGreaterThan_UIntInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void ThrowIfIsGreaterThan_UIntInstIsLowerThanUpperBound_NoExceptionThrown(uint inst, uint upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((ulong) 1, (ulong) 0)]
        [InlineData(ulong.MaxValue, ulong.MinValue)]
        public void ThrowIfIsGreaterThan_ULongInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((ulong) 0, (ulong) 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        public void ThrowIfIsGreaterThan_ULongInstIsLowerThanUpperBound_NoExceptionThrown(ulong inst, ulong upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((ushort) 1, (ushort) 0)]
        [InlineData(ushort.MaxValue, ushort.MinValue)]
        public void ThrowIfIsGreaterThan_UShortInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((ushort) 0, (ushort) 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        public void ThrowIfIsGreaterThan_UShortInstIsLowerThanUpperBound_NoExceptionThrown(ushort inst, ushort upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }
    }

    #endregion
}