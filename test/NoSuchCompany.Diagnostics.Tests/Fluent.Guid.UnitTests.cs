// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:46 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class FluentGuidTests
    {
        #region Public Methods

        [Fact]
        public void ThrowIfIsEmpty_GuidIsEmpty_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Guid.Empty.ThrowIfIsEmpty("instName"));
        }

        [Fact]
        public void ThrowIfIsEmpty_GuidIsNotEmpty_NoExceptionThrown()
        {
            Guid.NewGuid().ThrowIfIsEmpty("instName");
        }

        #endregion
    }

    #endregion
}