// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IShellBrowser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetToolbarItems32([NativeTypeName("LPTBBUTTONSB")] TBBUTTON32* lpButtons, uint nButtons, uint uFlags)
        {
            return ((delegate* unmanaged<IShellBrowser*, TBBUTTON32*, uint, uint, int>)(lpVtbl[17]))((IShellBrowser*)Unsafe.AsPointer(ref this), lpButtons, nButtons, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetToolbarItems32([NativeTypeName("LPTBBUTTONSB")] TBBUTTON64* lpButtons, uint nButtons, uint uFlags)
        {
            return ((delegate* unmanaged<IShellBrowser*, TBBUTTON64*, uint, uint, int>)(lpVtbl[17]))((IShellBrowser*)Unsafe.AsPointer(ref this), lpButtons, nButtons, uFlags);
        }
    }
}
