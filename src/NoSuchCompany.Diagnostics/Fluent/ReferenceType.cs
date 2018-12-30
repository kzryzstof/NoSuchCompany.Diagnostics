// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:33 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInstanceType"></typeparam>
    public class ReferenceType<TInstanceType> where TInstanceType : class
    {
        #region Constants

        private readonly ArgumentContext m_argumentContext;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the argument.
        /// </summary>
        protected string Name => m_argumentContext.Name;

        /// <summary>
        /// Gets the value of the argument.
        /// </summary>
        protected TInstanceType Value { get; }

        #endregion

        #region Constructors

        /// <param name="argumentContext"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argumentContext"/> instance is not specified.
        /// </exception>
        internal ReferenceType(ArgumentContext argumentContext, TInstanceType value)
        {
            Argument.ThrowIfIsNull(argumentContext, nameof(argumentContext));

            m_argumentContext = argumentContext;
            Value = value;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the reference is not null.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The current reference is not null.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReferenceType<TInstanceType> IsNotNull()
        {
            Argument.ThrowIfIsNotNull(Value, Name);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the reference does not match the exact <paramref name="expectedType"/>.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current reference does not match the <paramref name="expectedType"/>.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReferenceType<TInstanceType> IsNotType<TExpectedType>(TExpectedType expectedType)
        {
            Argument.ThrowIfIsNotType<TExpectedType>(Value, Name);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the reference is not specified.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The current reference is null.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReferenceType<TInstanceType> IsNull()
        {
            Argument.ThrowIfIsNull(Value, Name);

            return this;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the reference matches the exact <paramref name="expectedType"/>.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// Thrown if:
        /// - The current reference matches the <paramref name="expectedType"/>.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReferenceType<TInstanceType> IsType<TExpectedType>(TExpectedType expectedType)
        {
            Argument.ThrowIfIsType<TExpectedType>(Value, Name);

            return this;
        }

        #endregion
    }

    #endregion
}