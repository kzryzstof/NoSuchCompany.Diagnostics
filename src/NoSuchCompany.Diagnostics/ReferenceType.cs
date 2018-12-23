// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:33 AM
// Last author: Christophe Commeyne
// ==========================================================================

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public class ReferenceType<TInstanceType> where TInstanceType : class
    {
        #region Constants

        private readonly ArgumentInstance m_argumentInstanceName;

        private readonly TInstanceType m_argValue;

        #endregion

        #region Constructors

        public ReferenceType(ArgumentInstance argumentInstanceName, TInstanceType argValue)
        {
            m_argumentInstanceName = argumentInstanceName;
            m_argValue = argValue;
        }

        #endregion

        #region Public Methods

        public ReferenceType<TInstanceType> IsNotNull()
        {
            Argument.ThrowIfIsNotNull(m_argValue, m_argumentInstanceName.Name);

            return this;
        }

        public ReferenceType<TInstanceType> IsNotType<TExpectedType>(TExpectedType expectedType)
        {
            Argument.ThrowIfIsNotType<TExpectedType>(m_argValue, m_argumentInstanceName.Name);

            return this;
        }

        public ReferenceType<TInstanceType> IsNull()
        {
            Argument.ThrowIfIsNull(m_argValue, m_argumentInstanceName.Name);

            return this;
        }

        public ReferenceType<TInstanceType> IsType<TExpectedType>(TExpectedType expectedType)
        {
            Argument.ThrowIfIsType<TExpectedType>(m_argValue, m_argumentInstanceName.Name);

            return this;
        }

        #endregion
    }

    #endregion
}