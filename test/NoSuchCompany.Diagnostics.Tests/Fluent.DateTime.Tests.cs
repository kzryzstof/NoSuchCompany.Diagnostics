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

    public class FluentDateTimeTests
    {
        #region Public Methods

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsLocal_NoExceptionThrown()
        {
            DateTime.Now.ThrowIfIsNotLocal("instName");
        }

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsUtc_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => DateTime.UtcNow.ThrowIfIsNotLocal("instName"));
        }

        [Fact]
        public void ThrowIfIsNotUtc_DateTimeIsLocal_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => DateTime.Now.ThrowIfIsNotUtc("instName"));
        }

        [Fact]
        public void ThrowIfIsNotUtc_DateTimeIsUtc_NoExceptionThrown()
        {
            DateTime.UtcNow.ThrowIfIsNotUtc("instName");
        }

        #endregion
    }

    #endregion
}