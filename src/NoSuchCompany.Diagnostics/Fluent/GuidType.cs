// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 6:40 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    /// <summary>
    /// Defines a container for a <see cref="Guid" /> type.
    /// </summary>
    public sealed class GuidType : ValueType<Guid>
    {
        #region Constructors

        internal GuidType(ArgumentContext argumentContext, Guid value) : base(argumentContext, value)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the <see cref="Guid" />
        /// is empty.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current instance is empty.
        /// </exception>
        public GuidType IsEmpty()
        {
            Argument.ThrowIfIsEmpty(Value, Name);

            return this;
        }

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
        /// Breaks the polymorphism to return the <see cref="GuidType" /> and offer specific functionalities.
        /// </remarks>
        public new GuidType IsEqualTo(Guid otherInst)
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
        /// Breaks the polymorphism to return the <see cref="GuidType" /> and offer specific functionalities.
        /// </remarks>
        public new GuidType IsGreaterThan(Guid otherInst)
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
        /// Breaks the polymorphism to return the <see cref="GuidType" /> and offer specific functionalities.
        /// </remarks>
        public new GuidType IsLessThan(Guid otherInst)
        {
            base.IsLessThan(otherInst);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the <see cref="Guid" />
        /// is not empty.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current instance is not empty.
        /// </exception>
        public GuidType IsNotEmpty()
        {
            Argument.ThrowIfIsNotEmpty(Value, Name);

            return this;
        }

        #endregion
    }

    #endregion
}