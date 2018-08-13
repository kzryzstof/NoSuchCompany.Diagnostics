// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:42 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentGuidTests
    {
        #region Public Methods

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

        #endregion
    }

    #endregion
}