// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 2:49 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides methods that deal with primitive types.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the specified <paramref name="inst" />
        /// is equal to the <paramref name="otherValue" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherValue">Other value.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is equal to <paramref name="otherValue" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEqualTo<TValueType>(TValueType inst, TValueType otherValue, string instName) where TValueType : IComparable
        {
            if (inst.CompareTo(otherValue) == 0)
                throw new ArgumentException(instName, $"The value {instName} is equal to {otherValue}.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the specified <paramref name="inst" />
        /// is greater than the <paramref name="upperBound" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsGreaterThan<TValueType>(TValueType inst, TValueType upperBound, string instName) where TValueType : IComparable
        {
            if (inst.CompareTo(upperBound) > 0)
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is greater than {upperBound}. It is equal to {inst}.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the specified <paramref name="inst" />
        /// is greater than or equal to the <paramref name="upperBound" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsGreaterThanOrEqualTo<TValueType>(TValueType inst, TValueType upperBound, string instName) where TValueType : IComparable
        {
            if (inst.CompareTo(upperBound) >= 0)
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is greater than or equal to {upperBound}. It is equal to {inst}.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the specified <paramref name="inst" />
        /// is less than the <paramref name="lowerBound" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsLessThan<TValueType>(TValueType inst, TValueType lowerBound, string instName) where TValueType : IComparable
        {
            if (inst.CompareTo(lowerBound) < 0)
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is less than {lowerBound}. It is equal to {inst}.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the specified <paramref name="inst" />
        /// is less than or equal to the <paramref name="lowerBound" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is less than or equal to <paramref name="lowerBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsLessThanOrEqualTo<TValueType>(TValueType inst, TValueType lowerBound, string instName) where TValueType : IComparable
        {
            if (inst.CompareTo(lowerBound) <= 0)
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is less than or equal to {lowerBound}. It is equal to {inst}.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException" /> if the specified <paramref name="inst" />
        /// is not between the <paramref name="inclusiveLowerBound" /> and <paramref name="inclusiveUpperBound" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="inclusiveUpperBound"></param>
        /// <param name="instName">The name of the instance.</param>
        /// <param name="inclusiveLowerBound"></param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// - The <paramref name="inclusiveLowerBound" /> is greater than <paramref name="inclusiveUpperBound" />.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// - The <paramref name="inst" /> is not between <paramref name="inclusiveLowerBound" /> and
        /// <paramref name="inclusiveUpperBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotBetween<TValueType>(TValueType inst, TValueType inclusiveLowerBound, TValueType inclusiveUpperBound, string instName) where TValueType : IComparable
        {
            if (inclusiveLowerBound.CompareTo(inclusiveUpperBound) > 0)
                throw new ArgumentException($"The defined bounds are invalid: {nameof(inclusiveLowerBound)} ({inclusiveLowerBound}) is greater than {nameof(inclusiveUpperBound)} ({inclusiveUpperBound}).");

            ThrowIfIsLessThan(inst, inclusiveLowerBound, instName);

            ThrowIfIsGreaterThan(inst, inclusiveUpperBound, instName);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the specified <paramref name="inst" />
        /// is not equal to the <paramref name="otherValue" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherValue">Other value.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not equal to <paramref name="otherValue" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotEqualTo<TValueType>(TValueType inst, TValueType otherValue, string instName) where TValueType : IComparable
        {
            if (inst.CompareTo(otherValue) != 0)
                throw new ArgumentException(instName, $"The value {instName} is not equal to {otherValue}.");
        }

        #endregion
    }

    #endregion
}