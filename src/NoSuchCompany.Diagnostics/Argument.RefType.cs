// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:13 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the reference types.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TExpectedType">The expected type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified of the specified type.
        /// </exception>
        public static void ThrowIfIsNotType<TExpectedType>(object inst, string instName)
        {
            if (false == inst is TExpectedType)
                throw new ArgumentException(instName, $"The type of {instName} ({inst.GetType().Name}) is not a {typeof(TExpectedType).Name}.");
        }

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified.
        /// </exception>
        public static void ThrowIfIsNull<TType>(TType inst, string instName) where TType : class
        {
            if (inst == null)
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null.");
        }

        #endregion
    }

    #endregion
}