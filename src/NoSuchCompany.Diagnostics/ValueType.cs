// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:33 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public class ValueType<TInstanceType> where TInstanceType : struct, IComparable
    {
        #region Constants

        private readonly ArgumentInstance m_argumentInstanceName;

        private readonly TInstanceType m_argValue;

        #endregion

        #region Constructors

        public ValueType(ArgumentInstance argumentInstanceName, TInstanceType argValue)
        {
            m_argumentInstanceName = argumentInstanceName;
            m_argValue = argValue;
        }

        #endregion

        #region Public Methods

        public ValueType<TInstanceType> IsEqualTo(TInstanceType otherInst)
        {
            Argument.ThrowIfIsEqualTo(m_argValue, otherInst, m_argumentInstanceName.Name);

            return this;
        }

        public ValueType<TInstanceType> IsGreaterThan(TInstanceType otherInst)
        {
            Argument.ThrowIfIsGreaterThan(m_argValue, otherInst, m_argumentInstanceName.Name);

            return this;
        }

        public ValueType<TInstanceType> IsLessThan(TInstanceType otherInst)
        {
            Argument.ThrowIfIsLessThan(m_argValue, otherInst, m_argumentInstanceName.Name);

            return this;
        }

        public ValueType<TInstanceType> IsNotEqualTo(TInstanceType otherInst)
        {
            Argument.ThrowIfIsNotEqualTo(m_argValue, otherInst, m_argumentInstanceName.Name);

            return this;
        }

        #endregion
    }

    #endregion
}