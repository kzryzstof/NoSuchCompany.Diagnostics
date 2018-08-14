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
        public static ulong ThrowIfIsLessThan(this ulong inst, ulong lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static long ThrowIfIsLessThan(this long inst, long lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static int ThrowIfIsLessThan(this int inst, int lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static uint ThrowIfIsLessThan(this uint inst, uint lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static short ThrowIfIsLessThan(this short inst, short lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static ushort ThrowIfIsLessThan(this ushort inst, ushort lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static float ThrowIfIsLessThan(this float inst, float lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static double ThrowIfIsLessThan(this double inst, double lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        /// <param name="inst">Current value.</param>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if :
        /// <paramref name="inst" /> is lower than <paramref name="lowerBound" />.
        /// </exception>
        public static decimal ThrowIfIsLessThan(this decimal inst, decimal lowerBound, string instName)
        {
            Argument.ThrowIfIsLessThan(inst, lowerBound, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}