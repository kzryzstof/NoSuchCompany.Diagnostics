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

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="ICollection" /> type.
    /// </summary>
    public static partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TCollectionType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is an empty collection.
        /// </exception>
        public static TCollectionType ThrowIfIsEmpty<TCollectionType>(this TCollectionType inst, string instName) where TCollectionType : ICollection
        {
            Argument.ThrowIfIsEmpty(inst, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}