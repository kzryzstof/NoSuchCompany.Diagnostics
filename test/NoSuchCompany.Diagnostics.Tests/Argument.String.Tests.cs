using System;
using Xunit;
using NoSuchCompany.Diagnostics;
using System.Threading.Tasks;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class ArgumentStringTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNull_ArgumentNullExceptionThrown(string inst)
        {
            Assert.Throws<ArgumentNullException>(() => Argument.ThrowIfIsNullOrWhiteSpace(inst, "instName"));
        }

        [Theory]
        [InlineData("a")]
        [InlineData("_")]
        [InlineData("Moar characters")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNotNullOrWhitespace_NoExceptionThrown(string inst)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(inst, "instName");
        }
    }
}
