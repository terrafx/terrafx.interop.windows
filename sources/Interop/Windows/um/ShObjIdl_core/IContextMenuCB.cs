// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3409E930-5A39-11D1-83FA-00A0C90DC849")]
    [NativeTypeName("struct IContextMenuCB : IUnknown")]
    public unsafe partial struct IContextMenuCB
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContextMenuCB*, Guid*, void**, int>)(lpVtbl[0]))((IContextMenuCB*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContextMenuCB*, uint>)(lpVtbl[1]))((IContextMenuCB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContextMenuCB*, uint>)(lpVtbl[2]))((IContextMenuCB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CallBack(IShellFolder* psf, [NativeTypeName("HWND")] IntPtr hwndOwner, IDataObject* pdtobj, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IContextMenuCB*, IShellFolder*, IntPtr, IDataObject*, uint, nuint, nint, int>)(lpVtbl[3]))((IContextMenuCB*)Unsafe.AsPointer(ref this), psf, hwndOwner, pdtobj, uMsg, wParam, lParam);
        }
    }
}
