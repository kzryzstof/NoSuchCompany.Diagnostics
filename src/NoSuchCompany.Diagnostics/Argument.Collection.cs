// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 6:33 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Collections;
using System.Collections.Generic;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the classes implementing <see cref="IEnumerable{T}" />.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TCollectionType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is an empty collection.
        /// </exception>
        public static void ThrowIfIsEmpty<TCollectionType>(TCollectionType inst, string instName) where TCollectionType : ICollection
        {
            if (inst.Count == 0)
                throw new ArgumentException(instName, $"The collection {instName} does not have any items.");
        }

        #endregion
    }

    #endregion
}