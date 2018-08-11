using System;
namespace NoSuchCompany.Diagnostics
{
    public static partial class Fluent
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if <paramref name="inst"/> is either null or white space.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        public static string ThrowIfIsNullOrWhiteSpace(in string inst, string instName)
        {
            Argument.ThrowIfIsNullOrWhiteSpace(inst, instName);

            return inst;
        }
    }
}
