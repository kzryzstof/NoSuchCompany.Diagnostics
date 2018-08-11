using System;
namespace NoSuchCompany.Diagnostics
{
    public static partial class Argument
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if <paramref name="inst"/> is not specified.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TType">The 1st type parameter.</typeparam>
        public static void ThrowIfIsNull<TType>(in TType inst, string instName) where TType : class
        {
            if (inst == null)
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="inst"/> is not specified of the specified type.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="otherType">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TType">The 1st type parameter.</typeparam>
        public static void ThrowIfIsNotType<TExpectedType>(in object inst, string instName)
        {
            if (false == typeof(TExpectedType).IsAssignableFrom(inst.GetType()))
                throw new ArgumentException(instName, $"The type of {instName} ({inst.GetType().Name}) is not {typeof(TExpectedType).Name}.");
        }
    }
}
