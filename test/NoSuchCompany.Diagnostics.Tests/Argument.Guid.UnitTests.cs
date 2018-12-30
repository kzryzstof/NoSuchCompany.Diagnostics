// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 3:18 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentGuidTests
    {
        #region Tests

        [Fact]
        public void ThrowIfIsEmpty_GuidIsEmpty_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsEmpty(Guid.Empty, "instName"));
        }

        [Fact]
        public void ThrowIfIsEmpty_GuidIsNotEmpty_NoExceptionThrown()
        {
            Argument.ThrowIfIsEmpty(Guid.NewGuid(), "instName");
        }

        [Fact]
        public void ThrowIfIsEqualTo_GuidsAreEqual_ArgumentExceptionThrown()
        {
            Guid inst = Guid.Empty;
            Guid otherInst = Guid.Empty;

            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsEqualTo(inst, otherInst, "instName"));
        }

        [Fact]
        public void ThrowIfIsEqualTo_GuidsAreNotEqual_NoExceptionThrown()
        {
            Guid inst = Guid.Empty;
            Guid otherInst = Guid.NewGuid();

            Argument.ThrowIfIsEqualTo(inst, otherInst, "instName");
        }

        [Fact]
        public void ThrowIfIsNoEqualTo_GuidsAreNotEqual_ArgumentExceptionThrown()
        {
            Guid inst = Guid.Empty;
            Guid otherInst = Guid.NewGuid();

            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotEqualTo(inst, otherInst, "instName"));
        }

        [Fact]
        public void ThrowIfIsNotEqualTo_GuidsAreEqual_NoExceptionThrown()
        {
            Guid inst = Guid.Empty;
            Guid otherInst = Guid.Empty;

            Argument.ThrowIfIsNotEqualTo(inst, otherInst, "instName");
        }

        #endregion
    }

    #endregion
}