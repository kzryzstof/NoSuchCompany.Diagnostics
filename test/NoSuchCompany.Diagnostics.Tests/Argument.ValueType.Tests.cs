// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 23/12/2018 @ 5:42 PM
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

        [Theory]
        [InlineData(0.000000000000001, 0.0000000000000000)]
        [InlineData((double) 0, (double) -1)]
        [InlineData((double) 1, (double) 0)]
        [InlineData(double.MaxValue, double.MinValue)]
        [InlineData(0d, 0d)]
        public void ThrowIfIsGreaterThanOrEqualTo_DoubleInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(double inst, double upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData(0.0000000000000000, 0.0000000000000001)]
        [InlineData((double) -1, (double) 0)]
        [InlineData((double) 0, (double) 1)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_DoubleInstIsLowerThanUpperBound_NoExceptionThrown(double inst, double upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((float) 0.0000001, (float) 0.0000000)]
        [InlineData((float) 0, (float) -1)]
        [InlineData((float) 1, (float) 0)]
        [InlineData(float.MaxValue, float.MinValue)]
        [InlineData(0f, 0f)]
        public void ThrowIfIsGreaterThanOrEqualTo_FloatInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(float inst, float upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((float) 0.0000000, (float) 0.0000001)]
        [InlineData((float) -1, (float) 0)]
        [InlineData((float) 0, (float) 1)]
        [InlineData(float.MinValue, float.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_FloatInstIsLowerThanUpperBound_NoExceptionThrown(float inst, float upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(1, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        [InlineData(0, 0)]
        public void ThrowIfIsGreaterThanOrEqualTo_IntInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(int inst, int upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_IntInstIsLowerThanUpperBound_NoExceptionThrown(int inst, int upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((long) 0, (long) -1)]
        [InlineData((long) 1, (long) 0)]
        [InlineData(long.MaxValue, long.MinValue)]
        [InlineData(0L, 0L)]
        public void ThrowIfIsGreaterThanOrEqualTo_LongInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(long inst, long upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((long) -1, (long) 0)]
        [InlineData((long) 0, (long) 1)]
        [InlineData(long.MinValue, long.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_LongInstIsLowerThanUpperBound_NoExceptionThrown(long inst, long upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((short) 0, (short) -1)]
        [InlineData((short) 1, (short) 0)]
        [InlineData(short.MaxValue, short.MinValue)]
        [InlineData((short) 0, (short) 0)]
        public void ThrowIfIsGreaterThanOrEqualTo_ShortInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(short inst, short upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((short) -1, (short) 0)]
        [InlineData((short) 0, (short) 1)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_ShortInstIsLowerThanUpperBound_NoExceptionThrown(short inst, short upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((uint) 1, (uint) 0)]
        [InlineData(uint.MaxValue, uint.MinValue)]
        [InlineData((uint) 0, (uint) 0)]
        public void ThrowIfIsGreaterThanOrEqualTo_UIntInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_UIntInstIsLowerThanUpperBound_NoExceptionThrown(uint inst, uint upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((ulong) 1, (ulong) 0)]
        [InlineData(ulong.MaxValue, ulong.MinValue)]
        [InlineData(0UL, 0UL)]
        public void ThrowIfIsGreaterThanOrEqualTo_ULongInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((ulong) 0, (ulong) 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_ULongInstIsLowerThanUpperBound_NoExceptionThrown(ulong inst, ulong upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData((ushort) 1, (ushort) 0)]
        [InlineData(ushort.MaxValue, ushort.MinValue)]
        [InlineData((ushort) 0, (ushort) 0)]
        public void ThrowIfIsGreaterThanOrEqualTo_UShortInstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [InlineData((ushort) 0, (ushort) 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        public void ThrowIfIsGreaterThanOrEqualTo_UShortInstIsLowerThanUpperBound_NoExceptionThrown(ushort inst, ushort upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [InlineData(0.0000000000000001, 0.0000000000000000)]
        [InlineData((double) 0, (double) -1)]
        [InlineData((double) 1, (double) 0)]
        [InlineData(double.MaxValue, double.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_DoubleInstIsGreaterThanLowerBound_NoExceptionThrown(double inst, double lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0.0000000000000000, 0.0000000000000001)]
        [InlineData((double) -1, (double) 0)]
        [InlineData((double) 0, (double) 1)]
        [InlineData(double.MinValue, double.MaxValue)]
        [InlineData(0d, 0d)]
        public void ThrowIfIsLessThanOrEqualTo_DoubleInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(double inst, double lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((float) 0.0000001, (float) 0.0000000)]
        [InlineData((float) 0, (float) -1)]
        [InlineData((float) 1, (float) 0)]
        [InlineData(float.MaxValue, float.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_FloatInstIsGreaterThanLowerBound_NoExceptionThrown(float inst, float lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((float) 0.0000000, (float) 0.0000001)]
        [InlineData((float) -1, (float) 0)]
        [InlineData((float) 0, (float) 1)]
        [InlineData(float.MinValue, float.MaxValue)]
        [InlineData(0f, 0f)]
        public void ThrowIfIsLessThanOrEqualTo_FloatInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(float inst, float lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(1, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_IntInstIsGreaterThanLowerBound_NoExceptionThrown(int inst, int lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        [InlineData(0, 0)]
        public void ThrowIfIsLessThanOrEqualTo_IntInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(int inst, int lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((long) 0, (long) -1)]
        [InlineData((long) 1, (long) 0)]
        [InlineData(long.MaxValue, long.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_LongInstIsGreaterThanLowerBound_NoExceptionThrown(long inst, long lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((long) -1, (long) 0)]
        [InlineData((long) 0, (long) 1)]
        [InlineData(long.MinValue, long.MaxValue)]
        [InlineData(0L, 0L)]
        public void ThrowIfIsLessThanOrEqualTo_LongInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(long inst, long lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((short) 0, (short) -1)]
        [InlineData((short) 1, (short) 0)]
        [InlineData(short.MaxValue, short.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_ShortInstIsGreaterThanLowerBound_NoExceptionThrown(short inst, short lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((short) -1, (short) 0)]
        [InlineData((short) 0, (short) 1)]
        [InlineData(short.MinValue, short.MaxValue)]
        [InlineData((short) 0, (short) 0)]
        public void ThrowIfIsLessThanOrEqualTo_ShortInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(short inst, short lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(uint.MaxValue, uint.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_UIntInstIsGreaterThanLowerBound_NoExceptionThrown(uint inst, uint lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((uint) 0, (uint) 1)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        [InlineData((uint) 0, (uint) 0)]
        public void ThrowIfIsLessThanOrEqualTo_UIntInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ulong) 1, (ulong) 0)]
        [InlineData(ulong.MaxValue, ulong.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_ULongInstIsGreaterThanLowerBound_NoExceptionThrown(ulong inst, ulong lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ulong) 0, (ulong) 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        [InlineData(0UL, 0UL)]
        public void ThrowIfIsLessThanOrEqualTo_ULongInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ushort) 1, (ushort) 0)]
        [InlineData(ushort.MaxValue, ushort.MinValue)]
        public void ThrowIfIsLessThanOrEqualTo_UShortInstIsGreaterThanLowerBound_NoExceptionThrown(ushort inst, ushort lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ushort) 0, (ushort) 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        [InlineData((ushort) 0, (ushort) 0)]
        public void ThrowIfIsLessThanOrEqualTo_UShortInstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(0.0000000000000001, 0.0000000000000000)]
        [InlineData((double) 0, (double) -1)]
        [InlineData((double) 1, (double) 0)]
        [InlineData(double.MaxValue, double.MinValue)]
        public void ThrowIfIsLowerThan_DoubleInstIsGreaterThanLowerBound_NoExceptionThrown(double inst, double lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0.0000000000000000, 0.0000000000000001)]
        [InlineData((double) -1, (double) 0)]
        [InlineData((double) 0, (double) 1)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void ThrowIfIsLowerThan_DoubleInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(double inst, double lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((float) 0.0000001, (float) 0.0000000)]
        [InlineData((float) 0, (float) -1)]
        [InlineData((float) 1, (float) 0)]
        [InlineData(float.MaxValue, float.MinValue)]
        public void ThrowIfIsLowerThan_FloatInstIsGreaterThanLowerBound_NoExceptionThrown(float inst, float lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((float) 0.0000000, (float) 0.0000001)]
        [InlineData((float) -1, (float) 0)]
        [InlineData((float) 0, (float) 1)]
        [InlineData(float.MinValue, float.MaxValue)]
        public void ThrowIfIsLowerThan_FloatInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(float inst, float lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(1, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void ThrowIfIsLowerThan_IntInstIsGreaterThanLowerBound_NoExceptionThrown(int inst, int lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 1)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void ThrowIfIsLowerThan_IntInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(int inst, int lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((long) 0, (long) -1)]
        [InlineData((long) 1, (long) 0)]
        [InlineData(long.MaxValue, long.MinValue)]
        public void ThrowIfIsLowerThan_LongInstIsGreaterThanLowerBound_NoExceptionThrown(long inst, long lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((long) -1, (long) 0)]
        [InlineData((long) 0, (long) 1)]
        [InlineData(long.MinValue, long.MaxValue)]
        public void ThrowIfIsLowerThan_LongInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(long inst, long lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((short) 0, (short) -1)]
        [InlineData((short) 1, (short) 0)]
        [InlineData(short.MaxValue, short.MinValue)]
        public void ThrowIfIsLowerThan_ShortInstIsGreaterThanLowerBound_NoExceptionThrown(short inst, short lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((short) -1, (short) 0)]
        [InlineData((short) 0, (short) 1)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void ThrowIfIsLowerThan_ShortInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(short inst, short lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(uint.MaxValue, uint.MinValue)]
        public void ThrowIfIsLowerThan_UIntInstIsGreaterThanLowerBound_NoExceptionThrown(uint inst, uint lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(uint.MinValue, uint.MaxValue)]
        public void ThrowIfIsLowerThan_UIntInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ulong) 1, (ulong) 0)]
        [InlineData(ulong.MaxValue, ulong.MinValue)]
        public void ThrowIfIsLowerThan_ULongInstIsGreaterThanLowerBound_NoExceptionThrown(ulong inst, ulong lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ulong) 0, (ulong) 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue)]
        public void ThrowIfIsLowerThan_ULongInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [InlineData((ushort) 1, (ushort) 0)]
        [InlineData(ushort.MaxValue, ushort.MinValue)]
        public void ThrowIfIsLowerThan_UShortInstIsGreaterThanLowerBound_NoExceptionThrown(ushort inst, ushort lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [InlineData((ushort) 0, (ushort) 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue)]
        public void ThrowIfIsLowerThan_UShortInstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        #endregion

        [Theory]
        [InlineData(-0.000000000000001d, 0d, 1d)]
        [InlineData( 1.000000000000001d, 0d, 1d)]
        public void ThrowIfIsNotBetween_DoubleInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(double inst, double lowerBound, double upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData(-0.0000001f, 0f, 1f)]
        [InlineData( 1.0000001f, 0f, 1f)]
        public void ThrowIfIsNotBetween_FloatInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(float inst, float lowerBound, float upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData(-1, 0, 1)]
        [InlineData(2, 0, 1)]
        public void ThrowIfIsNotBetween_IntInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(int inst, int lowerBound, int upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData((uint)0, (uint)1, (uint)2)]
        [InlineData((uint)2, (uint)0, (uint)1)]
        public void ThrowIfIsNotBetween_UnsignedIntInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(uint inst, uint lowerBound, uint upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData((short)-1, (short)0, (short)1)]
        [InlineData((short)2, (short)0, (short)1)]
        public void ThrowIfIsNotBetween_ShortInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(short inst, short lowerBound, short upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData((ushort)0, (ushort)1, (ushort)2)]
        [InlineData((ushort)2, (ushort)0, (ushort)1)]
        public void ThrowIfIsNotBetween_UnsignedShortInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(ushort inst, ushort lowerBound, ushort upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData((ulong)0, (ulong)1, (ulong)2)]
        [InlineData((ulong)2, (ulong)0, (ulong)1)]
        public void ThrowIfIsNotBetween_LongInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(ulong inst, ulong lowerBound, ulong upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }

        [Theory]
        [InlineData((long)0, (long)1, (long)2)]
        [InlineData((long)2, (long)0, (long)1)]
        public void ThrowIfIsNotBetween_UnsignedLongInstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(long inst, long lowerBound, long upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsNotBetween(inst, lowerBound, upperBound, "instName"));
        }
    }

    #endregion
}