using System;
using Xunit;
using NoSuchCompany.Diagnostics;
using System.Threading.Tasks;

namespace NoSuchCompany.Diagnostics.Tests
{
    public class FluentStringTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNullOrWhiteSpace_ArgumentNullExceptionThrown(string inst)
        {
            Assert.Throws<ArgumentNullException>(() => Fluent.ThrowIfIsNullOrWhiteSpace(inst, "instName"));
        }

        [Theory]
        [InlineData("a")]
        [InlineData("_")]
        [InlineData("Moar characters")]
        public void ThrowIfIsNullOrWhiteSpace_InstIsNotNullOrWhitespace_NoExceptionThrown(string inst)
        {
            Fluent.ThrowIfIsNullOrWhiteSpace(inst, "instName");
        }
    }
}
