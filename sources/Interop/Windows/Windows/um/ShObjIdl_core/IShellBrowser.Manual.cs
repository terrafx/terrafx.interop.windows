// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct IShellBrowser
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetToolbarItems32([NativeTypeName("LPTBBUTTONSB")] TBBUTTON32* lpButtons, uint nButtons, uint uFlags)
    {
        return SetToolbarItems(lpButtons, nButtons, uFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetToolbarItems32([NativeTypeName("LPTBBUTTONSB")] TBBUTTON64* lpButtons, uint nButtons, uint uFlags)
    {
        return SetToolbarItems(lpButtons, nButtons, uFlags);
    }
}
