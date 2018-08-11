using System;
namespace NoSuchCompany.Diagnostics
{
    public static partial class Fluent
    {
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the DateTime <paramref name="inst"/> 
        /// is not expressed in the UTC time-zone.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        public static DateTime ThrowIfIsNotUtc(this DateTime inst, string instName)
        {
            Argument.ThrowIfIsNotUtc(inst, instName);

            return inst;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="inst"/> is not specified in a local time-zone.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        public static DateTime ThrowIfIsNotLocal(this DateTime inst, string instName)
        {
            Argument.ThrowIfIsNotLocal(inst, instName);

            return inst;
        }
    }
}
