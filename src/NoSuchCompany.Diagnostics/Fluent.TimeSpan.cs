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
    public static partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound"/>.
        /// </exception>
        public static TimeSpan ThrowIfIsLowerThan(this TimeSpan inst, TimeSpan lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Inst.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound"/>.
        /// </exception>
        public static TimeSpan ThrowIfIsGreaterThan(this TimeSpan inst, TimeSpan upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}