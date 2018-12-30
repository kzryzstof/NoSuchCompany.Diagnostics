// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:32 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    /// <summary>
    /// Defines the argument under validation.
    /// </summary>
    internal sealed class ArgumentContext
    {
        #region Properties

        /// <summary>
        /// Gets the name of the argument.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        /// <param name="argumentName"></param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argumentName"/> is not specified.
        /// </exception>
        public ArgumentContext(string argumentName)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(argumentName, nameof(argumentName));

            Name = argumentName;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Builds a new instance of <see cref="ValueType{TInstanceType}"/> representing a value-type.
        /// </summary>
        /// <typeparam name="TInstanceType"></typeparam>
        /// <param name="argValue"></param>
        /// <returns></returns>
        public ValueType<TInstanceType> BuildValueType<TInstanceType>(TInstanceType argValue) where TInstanceType : struct, IComparable
        {
            return new ValueType<TInstanceType>(this, argValue);
        }

        /// <summary>
        /// Builds a new instance of <see cref="DateTimeType"/> representing a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="argValue"></param>
        /// <returns></returns>
        public DateTimeType BuildDateTimeType(DateTime argValue)
        {
            return new DateTimeType(this, argValue);
        }

        /// <summary>
        /// Builds a new instance of <see cref="StringType"/> representing a <see cref="string"/>.
        /// </summary>
        /// <param name="argValue"></param>
        /// <returns></returns>
        public StringType BuildStringType(string argValue)
        {
            return new StringType(this, argValue);
        }

        /// <summary>
        /// Builds a new instance of <see cref="GuidType"/> representing a <see cref="Guid"/>.
        /// </summary>
        /// <param name="argValue"></param>
        /// <returns></returns>
        public GuidType BuildGuidType(Guid argValue)
        {
            return new GuidType(this, argValue);
        }

        /// <summary>
        /// Builds a new instance of <see cref="ReferenceType{TInstanceType}"/> representing a reference type.
        /// </summary>
        /// <param name="argValue"></param>
        /// <returns></returns>
        public ReferenceType<TInstanceType> BuildReferenceType<TInstanceType>(TInstanceType argValue) where TInstanceType : class
        {
            return new ReferenceType<TInstanceType>(this, argValue);
        }

        #endregion
    }

    #endregion
}