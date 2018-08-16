// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 14/08/2018 @ 6:32 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(ulong inst, ulong lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(long inst, long lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(int inst, int lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(uint inst, uint lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(short inst, short lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(ushort inst, ushort lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(float inst, float lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(double inst, double lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLessThan(decimal inst, decimal lowerBound, string instName)
        {
            ThrowIfIsLessThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        #endregion

        #region Private Methods

        private static void ThrowIfIsLessThan<TValue>(Func<bool> compareInst, TValue currentValue, TValue lowerBound, string instName)
        {
            if (compareInst())
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is less than {lowerBound}. It is equal to {currentValue}.");
        }

        #endregion
    }

    #endregion
}