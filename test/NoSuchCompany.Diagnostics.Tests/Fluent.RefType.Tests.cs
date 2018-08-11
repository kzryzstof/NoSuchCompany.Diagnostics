using System;
using Xunit;
using NoSuchCompany.Diagnostics;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class FluentRefTypeTests
    {
        [Fact]
        public void ThrowIfIsNull_InstIsNull_ArgumentNullExceptionThrown()
        {
            Exception exception = null;

            Assert.Throws<ArgumentNullException>(() => exception.ThrowIfIsNull("instName"));
        }
    }
}
