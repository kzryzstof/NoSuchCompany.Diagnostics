// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:25 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="TimeSpan" /> type.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the specified <paramref name="inst" />
        /// is equal to the <paramref name="otherInst" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">Other instance to compare.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is equal ton <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEqual(TimeSpan inst, TimeSpan otherInst, string instName)
        {
            if (inst == otherInst)
                throw new ArgumentException(instName, $"{instName} is equal to {otherInst}. (Value={inst}).");
        }
        
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if the specified <paramref name="inst" />
        /// is not equal to the <paramref name="otherInst" />.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">Other instance to compare.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotEqual(TimeSpan inst, TimeSpan otherInst, string instName)
        {
            if (inst != otherInst)
                throw new ArgumentException(instName, $"{instName} is not equal to {otherInst}. (Value={inst}).");
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
        public static void ThrowIfIsGreaterThan(TimeSpan inst, TimeSpan upperBound, string instName)
        {
            if (inst > upperBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is greater than {upperBound}. (Value={inst}).");
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
        /// <paramref name="inst" /> is greater than or equal to <paramref name="upperBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsGreaterThanOrEqualTo(TimeSpan inst, TimeSpan upperBound, string instName)
        {
            if (inst >= upperBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is greater than or equal to {upperBound}. (Value={inst}).");
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
        public static void ThrowIfIsLessThan(TimeSpan inst, TimeSpan lowerBound, string instName)
        {
            if (inst < lowerBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is lower than {lowerBound}. (Value={inst}).");
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
        /// <paramref name="inst" /> is lower than or equal to <paramref name="lowerBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsLessThanOrEqualTo(TimeSpan inst, TimeSpan lowerBound, string instName)
        {
            if (inst <= lowerBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is lower than or equal to {lowerBound}. (Value={inst}).");
        }

        #endregion
    }

    #endregion
}