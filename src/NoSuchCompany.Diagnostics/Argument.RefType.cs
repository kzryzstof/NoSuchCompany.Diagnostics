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
        public static void ThrowIfIsNull<TType>(TType inst, string instName) where TType : class
        {
            if (inst == null)
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null.");
        }
    }
}
