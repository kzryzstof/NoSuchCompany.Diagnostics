using System;
using Xunit;
using NoSuchCompany.Diagnostics;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class ArgumentRefTypeTests
    {
        [Fact]
        public void ThrowIfIsNull_InstIsNull_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNull<Exception>(null, "instName"));
        }
    }
}
