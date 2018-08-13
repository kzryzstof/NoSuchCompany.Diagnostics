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

    public class FluentStringTests
    {
        #region Public Methods

        [Theory]
        [InlineData("a")]
        [InlineData("_")]
        [InlineData("Moar characters")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNotNullOrWhitespace_NoExceptionThrown(string inst)
        {
            Fluent.ThrowIfIsNullOrWhiteSpace(inst, "instName");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNullOrWhiteSpace_ArgumentNullExceptionThrown(string inst)
        {
            Assert.Throws<ArgumentNullException>(() => Fluent.ThrowIfIsNullOrWhiteSpace(inst, "instName"));
        }

        #endregion
    }

    #endregion
}