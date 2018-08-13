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
    /// Provides checks for the <see cref="string"/> types.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is either null or is an empty string with blank characters.
        /// </exception>
        public static void ThrowIfIsNullOrWhiteSpace(string inst, string instName)
        {
            if (string.IsNullOrWhiteSpace(inst))
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null or empty.");
        }

        #endregion
    }

    #endregion
}