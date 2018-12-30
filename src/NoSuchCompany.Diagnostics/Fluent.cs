// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 08/09/2018 @ 10:38 AM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    public static class Fluent
    {
        #region Public Methods

        public static ValueType<DateTime> ThrowIf(this DateTime inst, string argName)
        {
            return new ArgumentInstance(argName).With(inst);
        }

        #endregion
    }

    #endregion
}