// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 4:27 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    /// <summary>
    /// Defines a container for a <see cref="DateTime"/> type.
    /// </summary>
    public sealed class DateTimeType : ValueType<DateTime>
    {
        #region Constructors

        internal DateTimeType(ArgumentContext argumentContext, DateTime value) : base(argumentContext, value)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the current instance
        /// is equal to the specified <paramref name="otherInst" />.
        /// </summary>
        /// <param name="otherInst"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current instance is equal to <paramref name="otherInst" />.
        /// </exception>
        /// <remarks>
        /// Breaks the polymorphism to return the <see cref="DateTimeType"/> and offer specific functionalities.
        /// </remarks>
        public new DateTimeType IsEqualTo(DateTime otherInst)
        {
            base.IsEqualTo(otherInst);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the current instance
        /// is less than the specified <paramref name="otherInst" />.
        /// </summary>
        /// <param name="otherInst"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if:
        /// - The current instance is greater than to <paramref name="otherInst" />.
        /// </exception>
        /// <remarks>
        /// Breaks the polymorphism to return the <see cref="DateTimeType"/> and offer specific functionalities.
        /// </remarks>
        public new DateTimeType IsGreaterThan(DateTime otherInst)
        {
            base.IsGreaterThan(otherInst);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the current instance
        /// is less than the specified <paramref name="otherInst" />.
        /// </summary>
        /// <param name="otherInst"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if:
        /// - The current instance is less than to <paramref name="otherInst" />.
        /// </exception>
        /// <remarks>
        /// Breaks the polymorphism to return the <see cref="DateTimeType"/> and offer specific functionalities.
        /// </remarks>
        public new DateTimeType IsLessThan(DateTime otherInst)
        {
            base.IsLessThan(otherInst);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the <see cref="DateTime" />
        /// is not specified in a local timezone.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current instance is not expressed in a local time zone.
        /// </exception>
        public DateTimeType IsNotLocal()
        {
            Argument.ThrowIfIsNotLocal(Value, Name);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the <see cref="DateTime" />
        /// is not specified in the UTC timezone.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current instance is not expressed in the UTC time zone.
        /// </exception>
        public DateTimeType IsNotUtc()
        {
            Argument.ThrowIfIsNotUtc(Value, Name);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the
        /// <see cref="DateTime" />'s kind is not specified.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current instance is not expressed either in the UTC time zone or in a local time zone.
        /// </exception>
        public DateTimeType IsUnspecified()
        {
            Argument.ThrowIfIsUnspecified(Value, Name);

            return this;
        }

        #endregion
    }

    #endregion
}