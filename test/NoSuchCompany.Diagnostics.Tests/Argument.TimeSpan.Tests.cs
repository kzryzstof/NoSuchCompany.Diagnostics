// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 14/08/2018 @ 7:21 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class ArgumentTimeSpanTests
    {
        private class TimeSpanData : IEnumerable<object[]>
        {
            private readonly List<object[]> m_data = new List<object[]>
            {
                new object[] { TimeSpan.MinValue, TimeSpan.Zero },
                new object[] { TimeSpan.FromMilliseconds(-1d), TimeSpan.Zero },
                new object[] { TimeSpan.MaxValue.Subtract(TimeSpan.FromMilliseconds(1d)), TimeSpan.MaxValue },
            };

            #region Public Methods

            public IEnumerator<object[]> GetEnumerator()
            {
                return m_data.GetEnumerator();
            }

            #endregion

            #region Private Methods

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            #endregion
        }

        [Theory]
        [ClassData(typeof(TimeSpanData))]
        public void ThrowIfIsLowerThan_InstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(TimeSpan inst, TimeSpan lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [ClassData(typeof(TimeSpanData))]
        public void ThrowIfIsLowerThan_InstIsGreaterThanLowerBound_NoExceptionThrown(TimeSpan lowerBound, TimeSpan inst)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, "instName");
        }

        [Theory]
        [ClassData(typeof(TimeSpanData))]
        public void ThrowIfIsGreaterThan_InstIsLowerThanUpperBound_NoExceptionThrown(TimeSpan inst, TimeSpan upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [ClassData(typeof(TimeSpanData))]
        public void ThrowIfIsGreaterThan_InstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(TimeSpan upperBound, TimeSpan inst)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
            
        }
    }

    #endregion
}