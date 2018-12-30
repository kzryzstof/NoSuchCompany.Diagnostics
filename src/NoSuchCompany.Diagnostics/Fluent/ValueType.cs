// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 30/12/2018 @ 4:29 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using System.Runtime.CompilerServices;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    /// <summary>
    /// Defines a context for a value type that can be compared.
    /// </summary>
    /// <typeparam name="TInstanceType"></typeparam>
    public class ValueType<TInstanceType> where TInstanceType : struct, IComparable
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
        internal ValueType(ArgumentContext argumentContext, TInstanceType value)
        {
            Argument.ThrowIfIsNull(argumentContext, nameof(argumentContext));

            m_argumentContext = argumentContext;
            Value = value;
        }

        #endregion

        #region Public Methods

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ValueType<TInstanceType> IsEqualTo(TInstanceType otherInst)
        {
            Argument.ThrowIfIsEqualTo(Value, otherInst, m_argumentContext.Name);

            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ValueType<TInstanceType> IsGreaterThan(TInstanceType otherInst)
        {
            Argument.ThrowIfIsGreaterThan(Value, otherInst, m_argumentContext.Name);

            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ValueType<TInstanceType> IsLessThan(TInstanceType otherInst)
        {
            Argument.ThrowIfIsLessThan(Value, otherInst, m_argumentContext.Name);

            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ValueType<TInstanceType> IsNotEqualTo(TInstanceType otherInst)
        {
            Argument.ThrowIfIsNotEqualTo(Value, otherInst, m_argumentContext.Name);

            return this;
        }

        #endregion
    }

    #endregion
}