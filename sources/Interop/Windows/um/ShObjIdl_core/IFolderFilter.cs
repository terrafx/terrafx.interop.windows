// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CC22886-DC8E-11D2-B1D0-00C04F8EEB3E")]
    [NativeTypeName("struct IFolderFilter : IUnknown")]
    public unsafe partial struct IFolderFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderFilter*, Guid*, void**, int>)(lpVtbl[0]))((IFolderFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderFilter*, uint>)(lpVtbl[1]))((IFolderFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderFilter*, uint>)(lpVtbl[2]))((IFolderFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldShow(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem)
        {
            return ((delegate* unmanaged<IFolderFilter*, IShellFolder*, ITEMIDLIST*, ITEMIDLIST*, int>)(lpVtbl[3]))((IFolderFilter*)Unsafe.AsPointer(ref this), psf, pidlFolder, pidlItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumFlags(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("DWORD *")] uint* pgrfFlags)
        {
            return ((delegate* unmanaged<IFolderFilter*, IShellFolder*, ITEMIDLIST*, IntPtr*, uint*, int>)(lpVtbl[4]))((IFolderFilter*)Unsafe.AsPointer(ref this), psf, pidlFolder, phwnd, pgrfFlags);
        }
    }
}
