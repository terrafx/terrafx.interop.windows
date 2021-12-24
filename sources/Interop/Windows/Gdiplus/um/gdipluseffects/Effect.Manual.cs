// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

public unsafe partial struct Effect : Effect.Interface
{
    private static void** s_vtbl = InitVtbl();

    private static void** InitVtbl()
    {
        var lpVtbl = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Effect), sizeof(void*) * 1);
        {
            lpVtbl[0] = (void*)(delegate* unmanaged<Effect*, void>)&Dispose;
        }
        return lpVtbl;

        [UnmanagedCallersOnly]
        static void Dispose(Effect* pThis)
        {
            pThis->Dispose();
        }
    }

    public Effect()
    {
        lpVtbl = s_vtbl;

        auxDataSize = 0;
        auxData = null;
        nativeEffect = null;
        useAuxData = 0;
    }
}
