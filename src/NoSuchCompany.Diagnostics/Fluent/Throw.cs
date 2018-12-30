// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:38 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics.Fluent
{
    #region Class

    /// <summary>
    /// 
    /// </summary>
    public static class Throw
    {
        #region Public Methods

        /// <summary>
        /// Builds a new instance of <see cref="DateTimeType"/> used to 
        /// validate a <see cref="DateTime"/> following the fluent language.
        /// </summary>
        /// <param name="inst"></param>
        /// <param name="argName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argName"/> instance is null or empty.
        /// </exception>
        public static DateTimeType If(this DateTime inst, string argName)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(argName, nameof(argName));

            return new ArgumentContext(argName).BuildDateTimeType(inst);
        }

        /// <summary>
        /// Builds a new instance of <see cref="ValueType{TInstanceType}"/> used to 
        /// validate a <typeparamref name="TInstanceType"/> following the fluent language.
        /// </summary>
        /// <param name="inst"></param>
        /// <param name="argName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argName"/> instance is null or empty.
        /// </exception>
        public static ValueType<TInstanceType> IfValue<TInstanceType>(this TInstanceType inst, string argName) where TInstanceType : struct, IComparable
        {
            Argument.ThrowIfIsNullOrWhiteSpace(argName, nameof(argName));

            return new ArgumentContext(argName).BuildValueType(inst);
        }

        /// <summary>
        /// Builds a new instance of <see cref="StringType"/> used to 
        /// validate a <see cref="string"/> following the fluent language.
        /// </summary>
        /// <param name="inst"></param>
        /// <param name="argName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argName"/> instance is null or empty.
        /// </exception>
        public static StringType If(this string inst, string argName)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(argName, nameof(argName));

            return new ArgumentContext(argName).BuildStringType(inst);
        }

        /// <summary>
        /// Builds a new instance of <see cref="GuidType"/> used to 
        /// validate a <see cref="Guid"/> following the fluent language.
        /// </summary>
        /// <param name="inst"></param>
        /// <param name="argName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argName"/> instance is null or empty.
        /// </exception>
        public static GuidType If(this Guid inst, string argName)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(argName, nameof(argName));

            return new ArgumentContext(argName).BuildGuidType(inst);
        }

        /// <summary>
        /// Builds a new instance of <see cref="ReferenceType{TInstanceType}"/> used to 
        /// validate a <typeparamref name="TInstanceType"/> following the fluent language.
        /// </summary>
        /// <param name="inst"></param>
        /// <param name="argName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if:
        /// - The <paramref name="argName"/> instance is null or empty.
        /// </exception>
        public static ReferenceType<TInstanceType> IfReference<TInstanceType>(this TInstanceType inst, string argName) where TInstanceType : class
        {
            Argument.ThrowIfIsNullOrWhiteSpace(argName, nameof(argName));

            return new ArgumentContext(argName).BuildReferenceType(inst);
        }

        #endregion
    }

    #endregion
}