// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:19 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentDateTimeTests
    {
        #region Public Methods

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsLocal_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotLocal(DateTime.Now, "instName");
        }

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsUtc_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotLocal(DateTime.UtcNow, "instName"));
        }

        [Fact]
        public void ThrowIfIsNotUtc_DateTimeIsLocal_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotUtc(DateTime.Now, "instName"));
        }

        [Fact]
        public void ThrowIfIsNotUtc_DateTimeIsUtc_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotUtc(DateTime.UtcNow, "instName");
        }

        #endregion
    }

    #endregion
}