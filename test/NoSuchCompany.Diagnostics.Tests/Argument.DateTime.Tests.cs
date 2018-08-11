using System;
using Xunit;
using NoSuchCompany.Diagnostics;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class ArgumentDateTimeTests
    {
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
        public void ThrowIfIsNotLocal_DateTimeIsUtc_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotLocal(DateTime.UtcNow, "instName"));
        }

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsLocal_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotLocal(DateTime.Now, "instName");
        }
    }
}
