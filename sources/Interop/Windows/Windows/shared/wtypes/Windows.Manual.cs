// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static nuint CBPCLIPDATA(CLIPDATA clipdata)
        => unchecked((nuint)clipdata.cbSize - (nuint)sizeof(int));

    public static void DECIMAL_SETZERO(DECIMAL* dec)
    {
        dec->Lo64 = 0;
        dec->Hi32 = 0;
        dec->signscale = 0;
    }
}
