// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:17 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the reference types.
    /// </summary>
    public static partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TExpectedType">The expected type of <paramref name="inst" />.</typeparam>
        /// <typeparam name="TType">The type of the instance to test.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified of the specified type.
        /// </exception>
        public static TType ThrowIfIsNotType<TType, TExpectedType>(this TType inst, string instName)
        {
            Argument.ThrowIfIsNotType<TExpectedType>(inst, instName);

            return inst;
        }

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified.
        /// </exception>
        public static TType ThrowIfIsNull<TType>(this TType inst, string instName) where TType : class
        {
            Argument.ThrowIfIsNull(inst, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}