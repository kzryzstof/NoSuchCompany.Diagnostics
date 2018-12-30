// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 4:37 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    public sealed class StringType : ReferenceType<string>
    {
        #region Constructors

        /// <param name="argumentContext"></param>
        /// <param name="argValue"></param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argumentContext" /> is not specified.
        /// </exception>
        internal StringType(ArgumentContext argumentContext, string argValue) : base(argumentContext, argValue)
        {
        }

        #endregion

        #region Public Methods

        public StringType IsEqualTo(string otherString)
        {
            Argument.ThrowIfIsEqualTo(Value, otherString, Name);

            return this;
        }

        public StringType IsEqualTo(string otherString, StringComparison stringComparison)
        {
            Argument.ThrowIfIsEqualTo(Value, otherString, Name, stringComparison);

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
            Argument.ThrowIfLengthIsEqualTo(Value, length, Name);

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
            Argument.ThrowIfLengthIsGreaterThan(Value, length, Name);

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
            Argument.ThrowIfLengthIsLessThan(Value, length, Name);

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
            Argument.ThrowIfLengthIsNotEqualTo(Value, length, Name);

            return this;
        }

        public StringType IsNotEqualTo(string otherString)
        {
            Argument.ThrowIfIsNotEqualTo(Value, otherString, Name);

            return this;
        }

        public StringType IsNotEqualTo(string otherString, StringComparison stringComparison)
        {
            Argument.ThrowIfIsNotEqualTo(Value, otherString, Name, stringComparison);

            return this;
        }

        public StringType IsNullOrEmpty()
        {
            Argument.ThrowIfIsNullOrEmpty(Value, Name);

            return this;
        }

        public StringType IsNullOrWhiteSpace()
        {
            Argument.ThrowIfIsNullOrWhiteSpace(Value, Name);

            return this;
        }

        #endregion
    }

    #endregion
}