using System;
using Xunit;
using NoSuchCompany.Diagnostics;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class FluentDateTimeTests
    {
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

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsUtc_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => DateTime.UtcNow.ThrowIfIsNotLocal("instName"));
        }

        [Fact]
        public void ThrowIfIsNotLocal_DateTimeIsLocal_NoExceptionThrown()
        {
            DateTime.Now.ThrowIfIsNotLocal("instName");
        }
    }
}
