// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:33 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public class StringType
    {
        #region Constants

        private readonly ArgumentInstance m_argumentInstanceName;

        private readonly string m_argValue;

        #endregion

        #region Constructors

        public StringType(ArgumentInstance argumentInstanceName, string argValue)
        {
            m_argumentInstanceName = argumentInstanceName;
            m_argValue = argValue;
        }

        #endregion

        #region Public Methods

        public StringType IsEqualTo(string otherString)
        {
            Argument.ThrowIfIsEqualTo(m_argValue, otherString, m_argumentInstanceName.Name);

            return this;
        }

        public StringType IsEqualTo(string otherString, StringComparison stringComparison)
        {
            Argument.ThrowIfIsEqualTo(m_argValue, otherString, m_argumentInstanceName.Name, stringComparison);

            return this;
        }

        /// <param name="length">The length of the string instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is equal to the specified
        /// <param name="length" />
        /// .
        /// </exception>
        public StringType IsLengthEqualTo(uint length)
        {
            Argument.ThrowIfLengthIsEqualTo(m_argValue, length, m_argumentInstanceName.Name);

            return this;
        }

        /// <param name="length">The length of the string instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is greater than the specified
        /// <param name="length" />
        /// .
        /// </exception>
        public StringType IsLengthGreaterThan(uint length)
        {
            Argument.ThrowIfLengthIsGreaterThan(m_argValue, length, m_argumentInstanceName.Name);

            return this;
        }

        /// <param name="length">The length of the string instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is less than the specified
        /// <param name="length" />
        /// .
        /// </exception>
        public StringType IsLengthLessThan(uint length)
        {
            Argument.ThrowIfLengthIsLessThan(m_argValue, length, m_argumentInstanceName.Name);

            return this;
        }

        /// <param name="length">The length of the string instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is not equal to the specified
        /// <param name="length" />
        /// .
        /// </exception>
        public StringType IsLengthNotEqualTo(uint length)
        {
            Argument.ThrowIfLengthIsNotEqualTo(m_argValue, length, m_argumentInstanceName.Name);

            return this;
        }

        public StringType IsNotEqualTo(string otherString)
        {
            Argument.ThrowIfIsNotEqualTo(m_argValue, otherString, m_argumentInstanceName.Name);

            return this;
        }

        public StringType IsNotEqualTo(string otherString, StringComparison stringComparison)
        {
            Argument.ThrowIfIsNotEqualTo(m_argValue, otherString, m_argumentInstanceName.Name, stringComparison);

            return this;
        }

        public StringType IsNullOrEmpty()
        {
            Argument.ThrowIfIsNullOrEmpty(m_argValue, m_argumentInstanceName.Name);

            return this;
        }

        public StringType IsNullOrWhiteSpace()
        {
            Argument.ThrowIfIsNullOrWhiteSpace(m_argValue, m_argumentInstanceName.Name);

            return this;
        }

        #endregion
    }

    #endregion
}