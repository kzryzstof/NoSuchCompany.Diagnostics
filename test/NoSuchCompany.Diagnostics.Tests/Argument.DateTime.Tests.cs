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

    public class ArgumentDateTimeTests
    {
        #region Tests

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

        [Fact]
        public void ThrowIfIsUnspecified_DateTimeIsLocal_NoExceptionThrown()
        {
            Argument.ThrowIfIsUnspecified(DateTime.Now, "instName");
        }

        [Fact]
        public void ThrowIfIsUnspecified_DateTimeIsUtc_NoExceptionThrown()
        {
            Argument.ThrowIfIsUnspecified(DateTime.UtcNow, "instName");
        }

        [Fact]
        public void ThrowIfIsUnspecified_DateTimeIsUtc_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsUnspecified(new DateTime(2018, 09, 08), "instName"));
        }

        #endregion
    }

    #endregion
}