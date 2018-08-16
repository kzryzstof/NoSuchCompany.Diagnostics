// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 14/08/2018 @ 6:59 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static ulong ThrowIfIsLowerThan(this ulong inst, ulong lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static long ThrowIfIsLowerThan(this long inst, long lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static int ThrowIfIsLowerThan(this int inst, int lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static uint ThrowIfIsLowerThan(this uint inst, uint lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static short ThrowIfIsLowerThan(this short inst, short lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static ushort ThrowIfIsLowerThan(this ushort inst, ushort lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static float ThrowIfIsLowerThan(this float inst, float lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static double ThrowIfIsLowerThan(this double inst, double lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static decimal ThrowIfIsLowerThan(this decimal inst, decimal lowerBound, string instName)
        {
            Argument.ThrowIfIsLowerThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static ulong ThrowIfIsGreaterThan(this ulong inst, ulong upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static long ThrowIfIsGreaterThan(this long inst, long upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static int ThrowIfIsGreaterThan(this int inst, int upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static uint ThrowIfIsGreaterThan(this uint inst, uint upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static short ThrowIfIsGreaterThan(this short inst, short upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static ushort ThrowIfIsGreaterThan(this ushort inst, ushort upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static float ThrowIfIsGreaterThan(this float inst, float upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static double ThrowIfIsGreaterThan(this double inst, double upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="upperBound">Upper bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is greater than <paramref name="upperBound" />.
        /// </exception>
        public static decimal ThrowIfIsGreaterThan(this decimal inst, decimal upperBound, string instName)
        {
            Argument.ThrowIfIsGreaterThan(inst, upperBound, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}