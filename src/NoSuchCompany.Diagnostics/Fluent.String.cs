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

    public static partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is either null or is an empty string with blank characters.
        /// </exception>
        public static string ThrowIfIsNullOrWhiteSpace(in string inst, string instName)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(inst, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}