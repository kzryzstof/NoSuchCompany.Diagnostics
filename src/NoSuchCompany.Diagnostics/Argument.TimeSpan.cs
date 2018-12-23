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
            if (inst > upperBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is greater than or equal to {upperBound}. (Value={inst}).");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsLowerThan(TimeSpan inst, TimeSpan lowerBound, string instName)
        {
            if (inst < lowerBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is lower than {lowerBound}. (Value={inst}).");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than or equal to <paramref name="lowerBound" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsLowerThanOrEqualTo(TimeSpan inst, TimeSpan lowerBound, string instName)
        {
            if (inst <= lowerBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is lower than or equal to {lowerBound}. (Value={inst}).");
        }

        #endregion
    }

    #endregion
}