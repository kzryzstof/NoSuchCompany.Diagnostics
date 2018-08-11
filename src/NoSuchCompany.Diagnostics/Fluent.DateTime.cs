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
            Argument.ThrowIfNotUtc(inst, instName);

            return inst;
        }
    }
}
