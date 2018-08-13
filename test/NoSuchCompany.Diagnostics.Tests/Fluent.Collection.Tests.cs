// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 6:35 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class FluentCollectionUnitTests
    {
        #region Public Methods

        [Theory]
        [ClassData(typeof(EmptyCollectionData))]
        public void ThrowIfIsEmpty_ArgumentExceptionThrown<TCollectionType>(TCollectionType inst) where TCollectionType : ICollection
        {
            Assert.Throws<ArgumentException>(() => inst.ThrowIfIsEmpty("instName"));
        }

        [Theory]
        [ClassData(typeof(NonEmptyCollectionData))]
        public void ThrowIfIsEmpty_NoExceptionExceptionThrown<TCollectionType>(TCollectionType inst) where TCollectionType : ICollection
        {
            inst.ThrowIfIsEmpty("instName");
        }

        #endregion

        private class EmptyCollectionData : IEnumerable<object[]>
        {
            #region Constants

            private readonly List<object[]> m_data = new List<object[]>
            {
                new object[] {new byte[0]},
                new object[] {new List<byte>()}

                //new object[] {Enumerable.Range(1, 0)}
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

        private class NonEmptyCollectionData : IEnumerable<object[]>
        {
            #region Constants

            private readonly List<object[]> m_data = new List<object[]>
            {
                new object[] {new byte[] {0x01}},
                new object[] {new List<byte> {0x01}}

                //new object[] {Enumerable.Range(1, 1)}
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
    }

    #endregion
}