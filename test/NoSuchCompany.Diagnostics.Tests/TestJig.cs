// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 6:42 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using NoSuchCompany.Diagnostics.Fluent;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class TestJig
    {
        #region Tests

        [Fact]
        public void Test()
        {
            Exception myException = null;
            DateTime timestampUtc = DateTime.UtcNow;
            uint unsignedInteger = 3;

            timestampUtc.If(nameof(timestampUtc))
                        .IsNotUtc()
                        .IsLessThan(DateTime.Now);

            unsignedInteger.IfValue(nameof(unsignedInteger)).IsLessThan(3);
            myException.IfReference(nameof(myException)).IsNull();
        }

        #endregion
    }

    #endregion
}