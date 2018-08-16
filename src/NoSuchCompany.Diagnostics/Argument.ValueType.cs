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
        public static void ThrowIfIsLowerThan(ulong inst, ulong lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(long inst, long lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(int inst, int lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(uint inst, uint lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(short inst, short lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(ushort inst, ushort lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(float inst, float lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(double inst, double lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static void ThrowIfIsLowerThan(decimal inst, decimal lowerBound, string instName)
        {
            ThrowIfIsLowerThan(() => inst < lowerBound, inst, lowerBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(ulong inst, ulong upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(long inst, long upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(int inst, int upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(uint inst, uint upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(short inst, short upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(ushort inst, ushort upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(float inst, float upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(double inst, double upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static void ThrowIfIsGreaterThan(decimal inst, decimal upperBound, string instName)
        {
            ThrowIfIsGreaterThan(() => inst > upperBound, inst, upperBound, instName);
        }

        #endregion

        #region Private Methods

        private static void ThrowIfIsGreaterThan<TValue>(Func<bool> compareInst, TValue currentValue, TValue upperBound, string instName)
        {
            if (compareInst())
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is greater than {upperBound}. It is equal to {currentValue}.");
        }

        private static void ThrowIfIsLowerThan<TValue>(Func<bool> compareInst, TValue currentValue, TValue lowerBound, string instName)
        {
            if (compareInst())
                throw new ArgumentOutOfRangeException(instName, $"The value {instName} is less than {lowerBound}. It is equal to {currentValue}.");
        }

        #endregion
    }

    #endregion
}