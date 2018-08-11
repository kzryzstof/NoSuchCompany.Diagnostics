using System;
namespace NoSuchCompany.Diagnostics
{
    public static partial class Fluent
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if <paramref name="inst"/> is not specified.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <typeparam name="TType">The 1st type parameter.</typeparam>
        public static TType ThrowIfIsNull<TType>(this TType inst, string instName) where TType : class
        {
            Argument.ThrowIfIsNull(inst, instName);

            return inst;
        }
    }
}
