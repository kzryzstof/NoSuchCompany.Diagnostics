// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:15 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="DateTime" /> type.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the <paramref name="inst"/>
        /// is not specified in a Local time zone.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in a local time zone.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotLocal(DateTime inst, string instName)
        {
            if (inst.Kind != DateTimeKind.Local)
                throw new ArgumentException(instName, $"{instName} is not expressed in a local time-zone.");
        }
        
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the <paramref name="inst"/>
        /// is not specified in the UTC time zone.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in the UTC time zone.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotUtc(DateTime inst, string instName)
        {
            if (inst.Kind != DateTimeKind.Utc)
                throw new ArgumentException(instName, $"{instName} is not expressed in the UTC time-zone.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the <paramref name="inst"/>
        /// is not specified in an Unspecified time zone.
        /// </summary>
        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in the UTC or the Local time zone.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsUnspecified(DateTime inst, string instName)
        {
            if (inst.Kind == DateTimeKind.Unspecified)
                throw new ArgumentException(instName, $"{instName} is not expressed in the UTC or the Local time-zone.");
        }

        #endregion
    }

    #endregion
}