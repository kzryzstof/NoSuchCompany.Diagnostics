using System;
namespace NoSuchCompany.Diagnostics
{
	public static partial class Argument
    {
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="inst"/> is not specified in the UTC time-zone.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        public static void ThrowIfNotUtc(DateTime inst, string instName)
        {
            if (inst.Kind != DateTimeKind.Utc)
                throw new ArgumentException(instName, $"{instName} is not allowed to be null.");
        }
    }
}
