// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:09 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="TimeSpan"/> type.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound"/>.
        /// </exception>
        public static void ThrowIfIsLowerThan(TimeSpan inst, TimeSpan lowerBound, string instName)
        {
            if (inst < lowerBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is lower than {lowerBound}. (Value={inst}).");
        }

        /// <param name="inst">Inst.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound"/>.
        /// </exception>
        public static void ThrowIfIsGreaterThan(TimeSpan inst, TimeSpan upperBound, string instName)
        {
            if (inst > upperBound)
                throw new ArgumentOutOfRangeException(instName, $"{instName} is greater than {upperBound}. (Value={inst}).");
        }

        #endregion
    }

    #endregion
}