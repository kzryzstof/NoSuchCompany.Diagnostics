// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:32 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public class ArgumentInstance
    {
        #region Properties

        /// <summary>
        /// Gets the name of the argument.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        public ArgumentInstance(string argumentName)
        {
            Name = argumentName;
        }

        #endregion

        #region Public Methods

        public ValueType<TInstanceType> With<TInstanceType>(TInstanceType argValue) where TInstanceType : struct, IComparable
        {
            return new ValueType<TInstanceType>(this, argValue);
        }

        public StringType With(string argValue)
        {
            return new StringType(this, argValue);
        }

        public ReferenceType<TInstanceType> WithInstance<TInstanceType>(TInstanceType argValue) where TInstanceType : class
        {
            return new ReferenceType<TInstanceType>(this, argValue);
        }

        #endregion
    }

    #endregion
}