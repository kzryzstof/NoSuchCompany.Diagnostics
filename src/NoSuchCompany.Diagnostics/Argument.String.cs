using System;
namespace NoSuchCompany.Diagnostics
{
	public static partial class Argument
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if <paramref name="inst"/> is either null or white space.
        /// </summary>
        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        public static void ThrowIfIsNullOrWhiteSpace(in string inst, string instName)
        {
            if (string.IsNullOrWhiteSpace(inst))
                throw new ArgumentNullException(instName, $"{instName} is not allowed to be null or white empty.");
        }
    }
}
