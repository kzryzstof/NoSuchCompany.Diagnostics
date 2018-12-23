// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 09/09/2018 @ 11:47 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the reference types.
    /// </summary>
    public static partial class Argument
    {
        #region Public Methods

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <typeparam name="TType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is specified.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotNull<TType>(TType inst, string instName) where TType : class
        {
            if (inst != null)
                throw new ArgumentException(instName, $"{instName} is specified.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <typeparam name="TExpectedType">The expected type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// The type of <paramref name="inst" /> does not match the expected type.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNotType<TExpectedType>(object inst, string instName)
        {
            if (inst.GetType() != typeof(TExpectedType))
                throw new ArgumentException(instName, $"The type of {instName} ({inst.GetType().Name}) is not a {typeof(TExpectedType).Name}: {inst.GetType().Name}");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <typeparam name="TType">The type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentNullException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsNull<TType>(TType inst, string instName) where TType : class
        {
            if (inst == null)
                throw new ArgumentNullException(instName, $"{instName} is null.");
        }

        /// <param name="inst">The instance to validate.</param>
        /// <param name="instName">The name of the instance.</param>
        /// <typeparam name="TExpectedType">The expected type of <paramref name="inst" />.</typeparam>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// The type of <paramref name="inst" /> matches the expected type.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfIsType<TExpectedType>(object inst, string instName)
        {
            if (inst.GetType() == typeof(TExpectedType))
                throw new ArgumentException(instName, $"The type of {instName} ({inst.GetType().Name}) is a {typeof(TExpectedType).Name}.");
        }

        #endregion
    }

    #endregion
}