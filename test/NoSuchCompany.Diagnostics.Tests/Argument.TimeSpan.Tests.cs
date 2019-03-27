// ==========================================================================
// Copyright (C) 2019 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 24/03/2019 @ 09:04
// Last author: 
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
        #region Tests

        [Theory]
        [ClassData(typeof(GreaterTimeSpanData))]
        public void ThrowIfIsGreaterThan_InstIsGreaterThanUpperBound_ArgumentOutOfRangeExceptionThrown(TimeSpan inst, TimeSpan upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName"));
        }

        [Theory]
        [ClassData(typeof(LowerOrEqualTimeSpanData))]
        public void ThrowIfIsGreaterThan_InstIsLowerThanUpperBound_NoExceptionThrown(TimeSpan inst, TimeSpan upperBound)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, "instName");
        }

        [Theory]
        [ClassData(typeof(GreaterOrEqualTimeSpanData))]
        public void ThrowIfIsGreaterThanOrEqualTo_InstIsGreaterThanOrEqualToUpperBound_ArgumentOutOfRangeExceptionThrown(TimeSpan inst, TimeSpan upperBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName"));
        }

        [Theory]
        [ClassData(typeof(LowerTimeSpanData))]
        public void ThrowIfIsGreaterThanOrEqualTo_InstIsLessThanUpperBound_NoExceptionThrown(TimeSpan inst, TimeSpan upperBound)
        {
            Argument.ThrowIfIsGreaterThanOrEqualTo(inst, upperBound, "instName");
        }

        [Theory]
        [ClassData(typeof(GreaterTimeSpanData))]
        public void ThrowIfIsLessThanOrEqualTo_InstIsGreaterThanLowerBound_NoExceptionThrown(TimeSpan inst, TimeSpan lowerBound)
        {
            Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName");
        }

        [Theory]
        [ClassData(typeof(LowerOrEqualTimeSpanData))]
        public void ThrowIfIsLessThanOrEqualTo_InstIsLowerThanOrEqualToLowerBound_ArgumentOutOfRangeExceptionThrown(TimeSpan inst, TimeSpan lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThanOrEqualTo(inst, lowerBound, "instName"));
        }

        [Theory]
        [ClassData(typeof(GreaterOrEqualTimeSpanData))]
        public void ThrowIfIsLowerThan_InstIsGreaterThanLowerBound_NoExceptionThrown(TimeSpan inst, TimeSpan lowerBound)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, "instName");
        }

        [Theory]
        [ClassData(typeof(LowerTimeSpanData))]
        public void ThrowIfIsLowerThan_InstIsLowerThanLowerBound_ArgumentOutOfRangeExceptionThrown(TimeSpan inst, TimeSpan lowerBound)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Argument.ThrowIfIsLessThan(inst, lowerBound, "instName"));
        }

        [Theory]
        [ClassData(typeof(NotEqualTimeSpanData))]
        public void ThrowIfIsNotEqualTo_InstIsNotEqualToOtherInst_ArgumentExceptionThrown(TimeSpan inst, TimeSpan otherInst)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsNotEqual(inst, otherInst, "instName"));
        }

        [Theory]
        [ClassData(typeof(EqualTimeSpanData))]
        public void ThrowIfIsEqualTo_InstIsEqualToOtherInst_ArgumentExceptionThrown(TimeSpan inst, TimeSpan otherInst)
        {
            Assert.Throws<ArgumentException>(() => Argument.ThrowIfIsEqual(inst, otherInst, "instName"));
        }

        #endregion

        #region Nested types

        /// <summary>
        /// Contains <see cref="TimeSpan" /> tuples with the 1st item being the lowest value.
        /// </summary>
        private class LowerTimeSpanData : IEnumerable<object[]>
        {
            #region Constants

            private readonly List<object[]> m_data = new List<object[]>
            {
                //  Lower limit.
                new object[] {TimeSpan.MinValue, TimeSpan.MinValue.Add(TimeSpan.FromMilliseconds(1d))},

                //  Upper limit.
                new object[] {TimeSpan.MaxValue.Subtract(TimeSpan.FromMilliseconds(1d)), TimeSpan.MaxValue}
            };

            #endregion

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

        /// <summary>
        /// Contains <see cref="TimeSpan" /> tuples with the 1st item being the lowest value.
        /// </summary>
        private class LowerOrEqualTimeSpanData : IEnumerable<object[]>
        {
            #region Constants

            private readonly List<object[]> m_data = new List<object[]>
            {
                //  Lower limit.
                new object[] {TimeSpan.MinValue, TimeSpan.MinValue.Add(TimeSpan.FromMilliseconds(1d))},

                //  Equality.
                new object[] {TimeSpan.Zero, TimeSpan.Zero},

                //  Upper limit.
                new object[] {TimeSpan.MaxValue.Subtract(TimeSpan.FromMilliseconds(1d)), TimeSpan.MaxValue}
            };

            #endregion

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

        /// <summary>
        /// Contains <see cref="TimeSpan" /> tuples with the 1st item being the greatest value.
        /// </summary>
        private class GreaterTimeSpanData : IEnumerable<object[]>
        {
            #region Constants

            /// <summary>
            /// Contains <see cref="TimeSpan" /> tuples with the 1st item being the greatest value.
            /// </summary>
            private readonly List<object[]> m_data = new List<object[]>
            {
                //  Lower limit.
                new object[] {TimeSpan.MinValue.Add(TimeSpan.FromMilliseconds(1d)), TimeSpan.MinValue},

                //  Upper limit.
                new object[] {TimeSpan.MaxValue, TimeSpan.MaxValue.Subtract(TimeSpan.FromMilliseconds(1d))}
            };

            #endregion

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

        /// <summary>
        /// Contains <see cref="TimeSpan" /> tuples with the 1st item being the greatest value.
        /// </summary>
        private class GreaterOrEqualTimeSpanData : IEnumerable<object[]>
        {
            #region Constants

            /// <summary>
            /// Contains <see cref="TimeSpan" /> tuples with the 1st item being the greatest value.
            /// </summary>
            private readonly List<object[]> m_data = new List<object[]>
            {
                //  Lower limit.
                new object[] {TimeSpan.MinValue.Add(TimeSpan.FromMilliseconds(1d)), TimeSpan.MinValue},

                //  Equality.
                new object[] {TimeSpan.Zero, TimeSpan.Zero},

                //  Upper limit.
                new object[] {TimeSpan.MaxValue, TimeSpan.MaxValue.Subtract(TimeSpan.FromMilliseconds(1d))}
            };

            #endregion

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

        /// <summary>
        /// Contains <see cref="TimeSpan" /> tuples with the 1st item not being equal to the other value.
        /// </summary>
        private class NotEqualTimeSpanData : IEnumerable<object[]>
        {
            #region Constants

            /// <summary>
            /// Contains <see cref="TimeSpan" /> tuples with the 1st item not being equal to the other value.
            /// </summary>
            private readonly List<object[]> m_data = new List<object[]>
            {
                //  Lower limit.
                new object[] {TimeSpan.MinValue.Add(TimeSpan.FromMilliseconds(1d)), TimeSpan.MinValue},

                new object[] {TimeSpan.Zero.Add(TimeSpan.FromMilliseconds(1d)), TimeSpan.Zero},

                //  Upper limit.
                new object[] {TimeSpan.MaxValue, TimeSpan.MaxValue.Subtract(TimeSpan.FromMilliseconds(1d))}
            };

            #endregion

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

        /// <summary>
        /// Contains <see cref="TimeSpan" /> non equal tuples.
        /// </summary>
        private class EqualTimeSpanData : IEnumerable<object[]>
        {
            #region Constants

            /// <summary>
            /// Contains <see cref="TimeSpan" /> equal tuples.
            /// </summary>
            private readonly List<object[]> m_data = new List<object[]>
            {
                //  Lower limit.
                new object[] {TimeSpan.MinValue, TimeSpan.MinValue},

                new object[] {TimeSpan.Zero, TimeSpan.Zero},

                //  Upper limit.
                new object[] {TimeSpan.MaxValue, TimeSpan.MaxValue}
            };

            #endregion

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

        #endregion
    }

    #endregion
}