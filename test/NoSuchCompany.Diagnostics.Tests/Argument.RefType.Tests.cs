using System;
using Xunit;
using NoSuchCompany.Diagnostics;
using System.Threading.Tasks;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class ArgumentRefTypeTests
    {
        [Fact]
        public void ThrowIfIsNull_InstIsNull_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNull<Exception>(null, "instName"));
        }

        [Fact]
        public void ThrowIfIsNotType_InstIsNotOfExpectedType_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotType<Exception>(Task.CompletedTask, "instName"));
        }

        [Fact]
        public void ThrowIfIsNotType_InstIsChildOfExpectedType_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotType<Exception>(new ArgumentOutOfRangeException(), "instName");
        }

        [Fact]
        public void ThrowIfIsNotType_InstIsExpectedType_NoExceptionThrown()
        {
            Argument.ThrowIfIsNotType<Exception>(new Exception(), "instName");
        }
    }
}
