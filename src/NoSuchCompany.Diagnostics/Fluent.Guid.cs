// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:37 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="Guid" /> type.
    /// </summary>
    public static partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is empty.
        /// </exception>
        public static Guid ThrowIfIsEmpty(this Guid inst, string instName)
        {
            Argument.ThrowIfIsEmpty(inst, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}