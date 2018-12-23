// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:12 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the classes implementing <see cref="IEnumerable{T}" />.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <typeparam name="TCollectionType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is an empty collection.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEmpty<TCollectionType>(TCollectionType inst, string instName) where TCollectionType : ICollection
        {
            if (inst.Count == 0)
                throw new ArgumentException(instName, $"The collection {instName} does not have any items.");
        }

        #endregion
    }

    #endregion
}