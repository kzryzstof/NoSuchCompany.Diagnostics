// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:09 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="DateTime"/> type.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in a local time zone.
        /// </exception>
        public static void ThrowIfIsNotLocal(DateTime inst, string instName)
        {
            if (inst.Kind != DateTimeKind.Local)
                throw new ArgumentException(instName, $"{instName} is not expressed in a local time-zone.");
        }

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in the UTC time zone.
        /// </exception>
        public static void ThrowIfIsNotUtc(DateTime inst, string instName)
        {
            if (inst.Kind != DateTimeKind.Utc)
                throw new ArgumentException(instName, $"{instName} is not expressed in the UTC time-zone.");
        }

        #endregion
    }

    #endregion
}