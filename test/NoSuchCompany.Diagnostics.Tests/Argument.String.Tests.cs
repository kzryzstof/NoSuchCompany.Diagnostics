// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 09/09/2018 @ 11:58 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentStringTests
    {
        #region Public Methods

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

        #endregion

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
    }

    #endregion
}