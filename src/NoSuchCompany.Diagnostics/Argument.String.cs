// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:24 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="string" /> types.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">Other instance</param>
        /// <param name="instName">The name of the instance</param>
        /// <param name="stringComparison"></param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEqualTo(string inst, string otherInst, string instName, StringComparison stringComparison)
        {
            if (string.Equals(inst, otherInst, stringComparison))
                throw new ArgumentException(instName, $"{instName} is equal to {otherInst}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">Other instance</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsEqualTo(string inst, string otherInst, string instName)
        {
            if (string.Equals(inst, otherInst))
                throw new ArgumentException(instName, $"{instName} is equal to {otherInst}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">Other instance</param>
        /// <param name="instName">The name of the instance</param>
        /// <param name="stringComparison"></param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotEqualTo(string inst, string otherInst, string instName, StringComparison stringComparison)
        {
            if (false == string.Equals(inst, otherInst, stringComparison))
                throw new ArgumentException(instName, $"{instName} is not equal to {otherInst}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="otherInst">Other instance</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not equal to <paramref name="otherInst" />.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotEqualTo(string inst, string otherInst, string instName)
        {
            if (false == string.Equals(inst, otherInst))
                throw new ArgumentException(instName, $"{instName} is not equal to {otherInst}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is either null or is an empty string.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNullOrEmpty(string inst, string instName)
        {
            if (string.IsNullOrEmpty(inst))
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null or empty.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is either null or a string with blank characters.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNullOrWhiteSpace(string inst, string instName)
        {
            if (string.IsNullOrWhiteSpace(inst))
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null or white spaced.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="length">The length of the string instance.</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is equal to the specified
        /// <param name="length" />
        /// .
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfLengthIsEqualTo(string inst, uint length, string instName)
        {
            ThrowIfIsNull(inst, instName);

            if (inst.Length == length)
                throw new ArgumentException(instName, $"The length {instName} is equal to {length}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="length">The length of the string instance.</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is greater than the specified
        /// <param name="length" />
        /// .
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfLengthIsGreaterThan(string inst, uint length, string instName)
        {
            ThrowIfIsNull(inst, instName);

            if (inst.Length > length)
                throw new ArgumentException(instName, $"The length {instName} is greater than {length}: {inst.Length}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="length">The length of the string instance.</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is greater than or equal to the specified
        /// <param name="length" />
        /// .
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfLengthIsGreaterThanOrEqualTo(string inst, uint length, string instName)
        {
            ThrowIfIsNull(inst, instName);

            if (inst.Length >= length)
                throw new ArgumentException(instName, $"The length {instName} is greater than or equal to {length}: {inst.Length}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="length">The length of the string instance.</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is less than the specified
        /// <param name="length" />
        /// .
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfLengthIsLessThan(string inst, uint length, string instName)
        {
            ThrowIfIsNull(inst, instName);

            if (inst.Length < length)
                throw new ArgumentException(instName, $"The length {instName} is less than {length}: {inst.Length}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="length">The length of the string instance.</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is less than or equal to the specified
        /// <param name="length" />
        /// .
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfLengthIsLessThanOrEqualTo(string inst, uint length, string instName)
        {
            ThrowIfIsNull(inst, instName);

            if (inst.Length <= length)
                throw new ArgumentException(instName, $"The length {instName} is less than or equal to {length}: {inst.Length}.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="length">The length of the string instance.</param>
        /// <param name="instName">The name of the instance</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" />'s length is not equal to the specified
        /// <param name="length" />
        /// .
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfLengthIsNotEqualTo(string inst, uint length, string instName)
        {
            ThrowIfIsNull(inst, instName);

            if (inst.Length != length)
                throw new ArgumentException(instName, $"The length {instName} is not equal to {length}: {inst.Length}");
        }

        #endregion
    }

    #endregion
}