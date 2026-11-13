// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public static HLOCAL LocalDiscard(HLOCAL h)
        => LocalReAlloc(h, 0, (uint)LMEM.LMEM_MOVEABLE);
}
