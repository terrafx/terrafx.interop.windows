// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2047E320-F2A9-11CE-AE65-08002B2E1262")]
    [NativeTypeName("struct IShellFolderViewCB : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellFolderViewCB
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderViewCB*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderViewCB*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderViewCB*, uint>)(lpVtbl[1]))((IShellFolderViewCB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderViewCB*, uint>)(lpVtbl[2]))((IShellFolderViewCB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT MessageSFVCB(uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IShellFolderViewCB*, uint, nuint, nint, int>)(lpVtbl[3]))((IShellFolderViewCB*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }
    }
}
