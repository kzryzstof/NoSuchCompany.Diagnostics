// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 09/09/2018 @ 11:45 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Threading.Tasks;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentRefTypeTests
    {
        #region Public Methods

        [Fact]
        public void ThrowIfIsNotNull_InstIsNotNull_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotNull(new Exception(), "instName"));
        }

        [Fact]
        public void ThrowIfIsNotNull_InstIsNull_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotNull<Exception>(null, "instName");
        }

        [Fact]
        public void ThrowIfIsNotType_InstIsChildOfExpectedType_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotType<Exception>(new ArgumentOutOfRangeException(), "instName"));
        }

        [Fact]
        public void ThrowIfIsNotType_InstIsExpectedType_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotType<Exception>(new Exception(), "instName");
        }

        [Fact]
        public void ThrowIfIsNotType_InstIsNotOfExpectedType_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotType<Exception>(Task.CompletedTask, "instName"));
        }

        [Fact]
        public void ThrowIfIsNull_InstIsNotNull_NoExceptionThrown()
        {
            Argument.ThrowIfIsNull(new Exception(), "instName");
        }

        [Fact]
        public void ThrowIfIsNull_InstIsNull_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNull<Exception>(null, "instName"));
        }

        [Fact]
        public void ThrowIfIsType_InstIsChildOfExpectedType_NoExceptionThrown()
        {
            Argument.ThrowIfIsType<Exception>(new ArgumentOutOfRangeException(), "instName");
        }

        [Fact]
        public void ThrowIfIsType_InstIsExpectedType_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsType<Exception>(new Exception(), "instName"));
        }

        [Fact]
        public void ThrowIfIsType_InstIsNotOfExpectedType_NoExceptionThrown()
        {
            Argument.ThrowIfIsType<Exception>(Task.CompletedTask, "instName");
        }

        #endregion
    }

    #endregion
}