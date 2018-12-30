// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 3:50 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentStringTests
    {
        #region Tests

        [Theory]
        [InlineData(" ")]
        [InlineData("_")]
        [InlineData("Moar characters")]
        public void ThrowIfIsNullOrEmpty_InstIsNotNullOrEmpty_NoExceptionThrown(string inst)
        {
            Argument.ThrowIfIsNullOrEmpty(inst, "instName");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ThrowIfIsNullOrEmpty_InstIsNull_ArgumentNullExceptionThrown(string inst)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNullOrEmpty(inst, "instName"));
        }

        [Theory]
        [InlineData("a")]
        [InlineData("_")]
        [InlineData("Moar characters")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNotNullOrWhitespace_NoExceptionThrown(string inst)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(inst, "instName");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNull_ArgumentNullExceptionThrown(string inst)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNullOrWhiteSpace(inst, "instName"));
        }

        [Theory]
        [InlineData(" ", "")]
        [InlineData("", " ")]
        [InlineData("M", "N")]
        public void ThrowIfIsEqualTo_InstIsNotEqual_NoExceptionThrown(string inst, string otherInst)
        {
            Argument.ThrowIfIsEqualTo(inst, otherInst, "instName");
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("M", "M")]
        public void ThrowIfIsEqualTo_InstIsEqual_ArgumentExceptionThrown(string inst, string otherInst)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsEqualTo(inst, otherInst, "instName"));
        }

        [Theory]
        [InlineData(" ", "")]
        [InlineData("", " ")]
        [InlineData("M", "N")]
        public void ThrowIfIsNotEqualTo_InstIsNotEqual_ArgumentExceptionThrown(string inst, string otherInst)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotEqualTo(inst, otherInst, "instName"));
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("M", "M")]
        public void ThrowIfIsNotEqualTo_InstIsEqual_NoExceptionThrown(string inst, string otherInst)
        {
            Argument.ThrowIfIsNotEqualTo(inst, otherInst, "instName");
        }

        [Theory]
        [InlineData(" ", "", StringComparison.CurrentCulture)]
        [InlineData("", " ", StringComparison.CurrentCulture)]
        [InlineData("M", "N", StringComparison.CurrentCulture)]
        [InlineData("M", "m", StringComparison.CurrentCulture)]
        public void ThrowIfIsEqualToWithStringComparison_InstIsNotEqual_NoExceptionThrown(string inst, string otherInst, StringComparison stringComparison)
        {
            Argument.ThrowIfIsEqualTo(inst, otherInst, "instName", stringComparison);
        }

        [Theory]
        [InlineData(" ", " ", StringComparison.CurrentCulture)]
        [InlineData("", "", StringComparison.CurrentCulture)]
        [InlineData("M", "M", StringComparison.CurrentCulture)]
        [InlineData("M", "m", StringComparison.CurrentCultureIgnoreCase)]
        public void ThrowIfIsEqualToWithStringComparison_InstIsEqual_ArgumentExceptionThrown(string inst, string otherInst, StringComparison stringComparison)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsEqualTo(inst, otherInst, "instName", stringComparison));
        }

        [Theory]
        [InlineData("", "", StringComparison.CurrentCulture)]
        [InlineData(" ", " ", StringComparison.CurrentCulture)]
        [InlineData("M", "M", StringComparison.CurrentCulture)]
        [InlineData("M", "m", StringComparison.CurrentCultureIgnoreCase)]
        public void ThrowIfIsNotEqualToWithStringComparison_InstIsEqual_NoExceptionThrown(string inst, string otherInst, StringComparison stringComparison)
        {
            Argument.ThrowIfIsNotEqualTo(inst, otherInst, "instName", stringComparison);
        }

        [Theory]
        [InlineData("", " ", StringComparison.CurrentCulture)]
        [InlineData("M", "O", StringComparison.CurrentCulture)]
        [InlineData("M", "m", StringComparison.CurrentCulture)]
        public void ThrowIfIsNotEqualToWithStringComparison_InstIsNotEqual_ArgumentExceptionThrown(string inst, string otherInst, StringComparison stringComparison)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotEqualTo(inst, otherInst, "instName", stringComparison));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        public void ThrowIfLengthIsEqualTo_LengthIsEqualTo_ArgumentExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfLengthIsEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", uint.MaxValue)]
        [InlineData(" ", uint.MaxValue)]
        public void ThrowIfLengthIsEqualTo_LengthIsNotEqualTo_NoExceptionThrown(string inst, uint length)
        {
            Argument.ThrowIfLengthIsEqualTo(inst, length, "instName");
        }

        [Theory]
        [InlineData(null, 1)]
        public void ThrowIfLengthIsEqualTo_StringIsNull_ArgumentNullExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfLengthIsEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData(" ", 0)]
        [InlineData("  ", 1)]
        public void ThrowIfLengthIsGreaterThan_LengthIsGreaterThan_ArgumentExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfLengthIsGreaterThan(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 2)]
        public void ThrowIfLengthIsGreaterThan_LengthIsNotGreaterThan_NoExceptionThrown(string inst, uint length)
        {
            Argument.ThrowIfLengthIsGreaterThan(inst, length, "instName");
        }

        [Theory]
        [InlineData(null, 0)]
        public void ThrowIfLengthIsGreaterThan_StringIsNull_ArgumentNullExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfLengthIsGreaterThan(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData("  ", 1)]
        public void ThrowIfLengthIsGreaterThanOrEqualTo_LengthIsGreaterThanOrEqualTo_ArgumentExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfLengthIsGreaterThanOrEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 1)]
        [InlineData(" ", 2)]
        public void ThrowIfLengthIsGreaterThanOrEqualTo_LengthIsNotGreaterThan_NoExceptionThrown(string inst, uint length)
        {
            Argument.ThrowIfLengthIsGreaterThanOrEqualTo(inst, length, "instName");
        }

        [Theory]
        [InlineData(null, 0)]
        public void ThrowIfLengthIsGreaterThanOrEqualTo_StringIsNull_ArgumentNullExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfLengthIsGreaterThanOrEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 1)]
        [InlineData(" ", 2)]
        public void ThrowIfLengthIsLessThan_LengthIsLessThan_ArgumentExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfLengthIsLessThan(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(" ", 1)]
        public void ThrowIfLengthIsLessThan_LengthIsNotLessThan_NoExceptionThrown(string inst, uint length)
        {
            Argument.ThrowIfLengthIsLessThan(inst, length, "instName");
        }

        [Theory]
        [InlineData(null, 0)]
        public void ThrowIfLengthIsLessThan_StringIsNull_ArgumentNullExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfLengthIsLessThan(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("", 1)]
        [InlineData(" ", 2)]
        public void ThrowIfLengthIsLessThanOrEqualTo_LengthIsLessThanOrEqualTo_ArgumentExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfLengthIsLessThanOrEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData(" ", 0)]
        [InlineData("  ", 1)]
        public void ThrowIfLengthIsLessThanOrEqualTo_LengthIsNotLessThan_NoExceptionThrown(string inst, uint length)
        {
            Argument.ThrowIfLengthIsLessThanOrEqualTo(inst, length, "instName");
        }

        [Theory]
        [InlineData(null, 0)]
        public void ThrowIfLengthIsLessThanOrEqualTo_StringIsNull_ArgumentNullExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfLengthIsLessThanOrEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 1)]
        [InlineData(" ", 0)]
        public void ThrowIfLengthIsNotEqualTo_LengthIsNotEqualTo_ArgumentExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfLengthIsNotEqualTo(inst, length, "instName"));
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        public void ThrowIfLengthIsNotEqualTo_LengthIsEqualTo_NoExceptionThrown(string inst, uint length)
        {
            Argument.ThrowIfLengthIsLessThan(inst, length, "instName");
        }

        [Theory]
        [InlineData(null, 0)]
        public void ThrowIfLengthIsNotEqualTo_StringIsNull_ArgumentNullExceptionThrown(string inst, uint length)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfLengthIsLessThan(inst, length, "instName"));
        }

        #endregion
    }

    #endregion
}