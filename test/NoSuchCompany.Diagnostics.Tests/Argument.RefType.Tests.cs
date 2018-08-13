// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:19 PM
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
        public void ThrowIfIsNotType_InstIsChildOfExpectedType_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotType<Exception>(new ArgumentOutOfRangeException(), "instName");
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
        public void ThrowIfIsNull_InstIsNull_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNull<Exception>(null, "instName"));
        }

        #endregion
    }

    #endregion
}