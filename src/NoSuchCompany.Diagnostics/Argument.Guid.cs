// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 09/09/2018 @ 8:18 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="Guid" /> type.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is empty.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEmpty(Guid inst, string instName)
        {
            if (inst == Guid.Empty)
                throw new ArgumentException(instName, $"{instName} is empty.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not empty.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotEmpty(Guid inst, string instName)
        {
            if (inst != Guid.Empty)
                throw new ArgumentException(instName, $"{instName} is not empty.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">The other instance to compare against.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEqualTo(Guid inst, Guid otherInst, string instName)
        {
            if (inst == otherInst)
                throw new ArgumentException(instName, $"{instName} is equal to {otherInst}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">The other instance to compare against.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotEqualTo(Guid inst, Guid otherInst, string instName)
        {
            if (inst != otherInst)
                throw new ArgumentException(instName, $"{instName} is not equal to {otherInst}.");
        }

        #endregion
    }

    #endregion
}