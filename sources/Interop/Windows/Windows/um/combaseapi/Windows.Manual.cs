// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static uint LISet32(ref LARGE_INTEGER li, uint value)
    {
        li.HighPart = unchecked((int)value) < 0 ? -1 : 0;
        li.LowPart = value;
        return value;
    }

    public static uint ULISet32(ref ULARGE_INTEGER li, uint value)
    {
        li.HighPart = 0;
        li.LowPart = value;
        return value;
    }
}
